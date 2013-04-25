/*
 * Created by SharpDevelop.
 * User: Angga
 * Date: 03/04/2012
 * Time: 5:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace asaProj
{
	/// <summary>
	/// Description of Line.
	/// </summary>
	public class Garis
	{
		private Point startPoint;
		private Point endPoint;
		private GraphicsPath p;
		//mengatasi garis bolak balik agar tidak menumpuk
		public bool goBack=false;
		
		public Garis()
		{
		}
		
		public GraphicsPath create(Point startPoint,Point endPoint,Color back){
			this.startPoint = startPoint;
			this.endPoint = endPoint;
			
			p=new GraphicsPath();
			
			p.StartFigure();
			if(goBack){
				startPoint.X=startPoint.X+10;
				startPoint.Y=startPoint.Y+10;
				endPoint.X=endPoint.X+10;
				endPoint.Y=endPoint.Y+10;
			}
			p.AddLine(startPoint,endPoint);			
			p.CloseFigure();
			
			return p;
		}
		
	}
}
