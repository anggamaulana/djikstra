/*
 * Created by SharpDevelop.
 * User: Angga
 * Date: 07/04/2012
 * Time: 14:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml; 
using System.Drawing;
using System.Drawing.Drawing2D;

namespace asaProj
{
	/// <summary>
	/// Description of dataXML.
	/// </summary>
	public class dataXML:XmlDocument
	{
		XmlNode docNode;
		XmlNode terminalNode;
		XmlNode kotaNode;
		XmlNode locationX;
		XmlNode locationY;
		XmlNode tujuan;
		XmlNode kotatujuan;

		private int index=0;
		
		public dataXML()
		{
			docNode = this.CreateXmlDeclaration("1.0", "UTF-8", null);
        	AppendChild(docNode);
			terminalNode = CreateElement("Terminal");
        	AppendChild(terminalNode);
		}
		
		public void setKota(Point pointLocation){
			kotaNode = CreateElement(this.index.ToString());
						
			locationX = CreateElement("locationX");
			locationX.AppendChild(CreateTextNode(pointLocation.X.ToString()));
			kotaNode.AppendChild(locationX);
			
			locationY = CreateElement("locationY");
			locationY.AppendChild(CreateTextNode(pointLocation.Y.ToString()));
			kotaNode.AppendChild(locationY);
			
			
			tujuan = CreateElement("tujuan");
			kotaNode.AppendChild(tujuan);
			
				
			
			terminalNode.AppendChild(kotaNode);
			this.index++;
		}
		
		public void addTujuan(int kotaAsal,int kotaTujuan,int jarak){
			
			
			kotatujuan = CreateElement(kotaTujuan.ToString());
			kotatujuan.AppendChild(CreateTextNode(jarak.ToString()));
			
			terminalNode.ChildNodes.Item(kotaAsal).SelectSingleNode("tujuan").AppendChild(kotatujuan);
		}
		
		public Point getKotaLocation(int index){
			Point p = new Point();
			p.X = Convert.ToInt32(terminalNode.ChildNodes[index].SelectNodes("locationX").Item(0).Value);
			p.Y = Convert.ToInt32(terminalNode.ChildNodes[index].SelectSingleNode("locationY").Value);
			
			return p;
			
		}
		
		public XmlNode getKota(int index){
			return this.terminalNode.ChildNodes[index];
		}
		public XmlNode getKotaTujuan(int indexkotaasal){
			return getKota(indexkotaasal).ChildNodes[2];
		}
		
		public int getJumlahKota(){
			return this.terminalNode.ChildNodes.Count;
		}
		
		
		public String result(){
			String s="";
			XmlReader r = new XmlNodeReader(terminalNode);
        

        while (r.Read()) {
            if (r.NodeType == XmlNodeType.Element) {
                s+="<" + r.Name + ">\n";
                if (r.HasAttributes) {
                    for (int i = 0; i < r.AttributeCount; i++) {
                        s+="\tATTRIBUTE: " +
                          r.GetAttribute(i)+"\n";
                		
                    }
                }
            } else if (r.NodeType == XmlNodeType.Text) {
               s+="\t" + r.Value+"\n";
            }
        }
			return s;
		}
		
		public void Destroy(){
			this.terminalNode.RemoveAll();
		}
		
	}
}
