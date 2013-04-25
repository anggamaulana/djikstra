/*
 * Created by SharpDevelop.
 * User: Angga
 * Date: 07/04/2012
 * Time: 13:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace asaProj
{
	/// <summary>
	/// Description of jarakTerminal.
	/// </summary>
	public partial class jarakTerminal : Form
	{
		private MainForm main;
		private dataXML data;
		private int kotaAsal;
		private int kotaTujuan;
		private Point Start;
		private Point End;
		
		
		
		public jarakTerminal(MainForm main,dataXML data,int kotaAsal,int kotaTujuan,Point start,Point end)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.main=main;
			this.data = data;
			this.kotaAsal = kotaAsal;
			this.kotaTujuan=kotaTujuan;
			this.Start=start;
			this.End=end;
			indekskotaasal.Text = kotaAsal.ToString();
			
		}
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			try{
			int jarak = Convert.ToInt32(jaraktb.Text);
			this.data.addTujuan(this.kotaAsal,this.kotaTujuan,jarak);
			main.manipulasiData(this.data,koordinatLabel(),jarak);
			Close();
			}catch(FormatException fe){
				MessageBox.Show("jarak harus angka \n"+fe.Message);
			}
		}
		
		
		private Point koordinatLabel(){
			Point koordinat=new Point();
				
			if(this.Start.X<this.End.X){
				int selisih=(this.End.X-this.Start.X)/2;
				koordinat.X=this.Start.X+selisih;
				
			}else{
				int selisih=(this.Start.X-this.End.X)/2;
				koordinat.X=this.Start.X-selisih;
			}
			
			if(this.Start.Y<this.End.Y){
				int selisih=(this.End.Y-this.Start.Y)/2;
				koordinat.Y=this.Start.Y+selisih;
				
			}else{
				int selisih=(this.Start.Y-this.End.Y)/2;
				koordinat.Y=this.Start.Y-selisih;
			}
			
			return koordinat;
			
		}
	}
}
