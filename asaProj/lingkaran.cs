/*
 * Created by SharpDevelop.
 * User: Angga
 * Date: 02/04/2012
 * Time: 18:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace asaProj
{
	/// <summary>
	/// Description of lingkaran.
	/// </summary>
	public class lingkaran
	{
		private int radius;
		private Point location;
		private String teks;
		private Color backcolor;
		private Point center;
		GraphicsPath path;
		
		public lingkaran()
		{
			
		}
		
		public GraphicsPath create(Point location,int radius,String Teks, Color back){
			this.location.X = location.X-radius;
			this.location.Y = location.Y-radius;
			this.radius = radius;
			this.teks = Teks;
			this.backcolor = back;
			path = new GraphicsPath();
			FontFamily family = new FontFamily("tahoma");
			int style = (int)FontStyle.Regular;
			StringFormat format = StringFormat.GenericDefault;
			
			path.StartFigure();
			
			path.AddString(Teks,family,style,12,new Point(location.X-5,location.Y-5),format);
			path.AddEllipse(this.location.X,this.location.Y,radius*2,radius*2);
			
			
			path.CloseFigure();
			
			return path;
		}
		
		public void setRadius(int x){
			this.radius = x;
		}
		public void setLocation(Point x){
			this.location = x;
		}
		public Point getCenterPoint(){
			center.X=this.location.X+this.radius;
			center.Y=this.location.Y+this.radius;
			return center;
		}
		
		public void setString(String x){
			this.teks = x;
		}
		
		
		
		
	}
}
