/*
 * Created by SharpDevelop.
 * User: Angga
 * Date: 02/04/2012
 * Time: 18:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml;

namespace asaProj
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		private jarakTerminal jt;
		private Simulasi sim;
		public dataXML data;
		
		private int objekActive=-1;
		private int indexCircleOver;
		private int radiusCircle=20;
		private int kotaasal=0;
		private int jmlahlingkaranterminal=1;
		
		
		private bool isPickendline=false;
		private List<lingkaran> objekLingkaran = new List<lingkaran>();
		private List<GraphicsPath> terminal = new List<GraphicsPath>();
		private List<GraphicsPath> lineConnection = new List<GraphicsPath>();
		private List<Point> terminalLocation = new List<Point>();		
		private List<Point> startPoint = new List<Point>();
		private List<Point> endPoint = new List<Point>();
		private List<Point> KoordinatJarak = new List<Point>();
		private List<String> labelJarak = new List<String>();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			data = new dataXML();
		}	
		
		
		void LingkaranClick(object sender, EventArgs e)
		{
			this.objekActive =0;
			this.lingkaran.Enabled=false;
			this.garis.Enabled=true;
			
		}
		
		
		void GarisClick(object sender, EventArgs e)
		{
			this.objekActive =1;
			this.garis.Enabled=false;
			this.lingkaran.Enabled=true;
			
		}
		
		void AreaMouseDown(object sender, MouseEventArgs e)
		{
			
			
		}
		
		void AreaPaint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Pen pn = new Pen(Color.Black);
			 pn.EndCap = LineCap.ArrowAnchor;
			
			
			foreach(GraphicsPath li in lineConnection){
				e.Graphics.DrawPath(pn,li);				
			}
			
			foreach(GraphicsPath p in terminal){
				
				e.Graphics.DrawPath(new Pen(Color.White),p);
				e.Graphics.FillPath(Brushes.Blue,p);
			}
			 
			 
			for(int i=0;i<labelJarak.Count;i++){
			 	e.Graphics.DrawString(labelJarak[i],new Font(new FontFamily("tahoma"),10),Brushes.Red,KoordinatJarak[i].X,KoordinatJarak[i].Y);
			}
			 
			
		}
		
		void AreaMouseUp(object sender, MouseEventArgs e)
		{
			
		try{
			
			Point location = new Point();
			location.X = e.X;location.Y=e.Y;
			
			
			if(this.objekActive == 0){
				if(terminal.Count!=0 ){
					if(isMouseOverCircle(location,out indexCircleOver)){
						MessageBox.Show("over");
						
					}else{
						terminalLocation.Add(new Point(e.X,e.Y));
						lingkaran l = new lingkaran();
						terminal.Add(l.create(location,radiusCircle,this.jmlahlingkaranterminal.ToString(),Color.Black));
						data.setKota(new Point(e.X,e.Y));
						this.jmlahlingkaranterminal++;
						jmlkota.Text = this.jmlahlingkaranterminal.ToString();
					}
					
						
				}else{
					terminalLocation.Add(new Point(e.X,e.Y));
					lingkaran l = new lingkaran();
					terminal.Add(l.create(location,radiusCircle,"0",Color.Black));
					data.setKota(new Point(e.X,e.Y));
					jmlkota.Text = this.jmlahlingkaranterminal.ToString();
					
				}
				
			}else{
				if(terminal.Count!=0){
					if(isMouseOverCircle(location,out indexCircleOver)){
						
						if(isPickendline){
							
							Point tujuan = new Point(terminalLocation[indexCircleOver].X,terminalLocation[indexCircleOver].Y);
							if(!isEndPointOverStartpoint(tujuan)){
							   	if(!isLineAlreadyExist(startPoint[startPoint.Count-1],tujuan)){
							   		endPoint.Add(tujuan);
							   		Garis li = new Garis();
							   		//jika garis untuk kembali, agar tidak tampil menumpuk
							   		if(isLineGoBack(startPoint[startPoint.Count-1],tujuan)){
							   			li.goBack=true;
							   			lineConnection.Add(li.create(startPoint[startPoint.Count-1],endPoint[endPoint.Count-1],Color.Black));
							   		}else{
							   			lineConnection.Add(li.create(startPoint[startPoint.Count-1],endPoint[endPoint.Count-1],Color.Black));
							   		}
							   		jt = new jarakTerminal(this,this.data,kotaasal,indexCircleOver,startPoint[startPoint.Count-1],tujuan);
							   		jt.ShowDialog();
							   		isPickendline=false;
							   	}else{
							   		MessageBox.Show("Garis penghubung sudah ada");
							   		startPoint.RemoveAt(startPoint.Count-1);
									isPickendline=false;
							   	}
							}else{
								MessageBox.Show("Anda tidak bisa memilih point tujuan yang sama");
								startPoint.RemoveAt(startPoint.Count-1);
								isPickendline=false;
							}
							
						}else{
							startPoint.Add(new Point(terminalLocation[indexCircleOver].X,terminalLocation[indexCircleOver].Y));
							isPickendline=true;
							kotaasal=indexCircleOver;
							MessageBox.Show("Silahkan pilih Kota tujuan dari kota asal "+indexCircleOver);
						}
					}else{
						if(isPickendline==true)
							MessageBox.Show("anda belum memilih point tujuan");
					}
				}
				
				
			}
			//refresh
					this.area.Invalidate();
		
		}catch(Exception ex){
						MessageBox.Show("Maaf terjadi Bug Aplikasi akan ditutup\n"+ex.Message);
						Application.Exit();
		}
			
		}
		
		private bool isMouseOverCircle(Point Location,out int indexCircleOver){
			int index=0;
			
			foreach(System.Drawing.Drawing2D.GraphicsPath li in terminal){			
				
					if(li.IsVisible(Location.X,Location.Y)){
						indexCircleOver = index;
						return true;
						
					}	
				index++;
			}
			indexCircleOver=-1;
			return false;
			
		}
		
		private bool isEndPointOverStartpoint(Point endpoint){
			if(startPoint[startPoint.Count-1]==endpoint)
				return true;
			else
				return false;
		}
		
		private bool isLineAlreadyExist(Point startpoint,Point endpoint){
			if(endPoint.Count!=0){
			   	for(int i=0;i<endPoint.Count;i++){
			   		if(startPoint[i]==startpoint && endPoint[i]==endpoint)
			   			return true;
			   	}
			}
			   	
			   	return false;
			
		}
		private bool isLineGoBack(Point startpoint,Point endpoint){
			for(int i=0;i<endPoint.Count;i++){
				if(startpoint==endPoint[i] && endpoint==startPoint[i])
					return true;
				
			}
			return false;
		}
		
		public void manipulasiData(dataXML data,Point labelJarak,int jarak){
			this.data=data;
			this.KoordinatJarak.Add(labelJarak);
			this.labelJarak.Add(jarak.ToString());
		}
		
		void ResetClick(object sender, EventArgs e)
		{
			terminal.Clear();
			terminalLocation.Clear();
			startPoint.Clear();
			endPoint.Clear();
			lineConnection.Clear();
			labelJarak.Clear();
			KoordinatJarak.Clear();
			this.area.Invalidate();
			this.data.Destroy();
			jmlkota.Text="";
			this.jmlahlingkaranterminal=1;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			sim = new Simulasi(this,this.data);
			sim.ShowDialog();
            
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Aplikasi Algoritma Dijkstra\n by:aanx04");
		}
	}
}
