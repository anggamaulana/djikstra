/*
 * Created by SharpDevelop.
 * User: Angga
 * Date: 08/04/2012
 * Time: 18:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace asaProj
{
	/// <summary>
	/// Description of Simulasi.
	/// </summary>
	public partial class Simulasi : Form
	{
		
		private MainForm main;
		private dataXML data;
		private int[,] Matriks;
		private int[] Simpul;
		private int[] d;
		private String[] Rute;
		private Stopwatch sw;
		
		
		public Simulasi(MainForm main,dataXML data)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.main=main;
			this.data=data;
			
			this.Matriks = new int[data.getJumlahKota(),data.getJumlahKota()];
			this.Matriks=generateMatriks(data,data.getJumlahKota());				
			this.Simpul = new int[data.getJumlahKota()];
			this.d = new int[data.getJumlahKota()];
			this.Rute=new String[data.getJumlahKota()];
			
			datadarixml.Text=parseXML();
			populateCB();
			sw = new Stopwatch();
		}
		
		
		private String parseXML(){
			String hasil="";
			
			for(int i=0;i<this.data.getJumlahKota();i++){
				hasil+="Jarak Dari kota "+i+" ke : ";
				
				for(int j=0;j<this.data.getKotaTujuan(i).ChildNodes.Count;j++){
					hasil+=" Kota "+this.data.getKotaTujuan(i).ChildNodes[j].Name+" = "+this.data.getKotaTujuan(i).ChildNodes[j].InnerText+" Km || ";
				}
				hasil+="\n\n";
			}
			hasil+="-----------------------------------------------------------------------------";
			
			return hasil;
		}
		
		private String getDArray(){
			String s="";
			for(int i=0;i<this.d.Length;i++){
				
					s+=this.d[i].ToString()+"  ";
				
					
			}
			return s;
		}
		
		private String getSimpul(){
			String s="";
			for(int i=0;i<this.Simpul.Length;i++){
				
					s+=this.Simpul[i].ToString()+"  ";
				
					
			}
			return s;
		}
		
		
		
		private String getMatriks(){
			String s="";
			for(int i=0;i<this.Matriks.GetLength(0);i++){
				for(int j=0;j<this.Matriks.GetLength(1);j++){
					s+=this.Matriks[i,j].ToString()+"  ";
				}
				s+="\n";
					
			}
			return s;
		}
		
		private int[,] generateMatriks(dataXML data,int jmlKota){
			int[,] matriks = new int[jmlKota,jmlKota];
			
			
			for(int i=0;i<jmlKota;i++){
				
				int jumlahTujuan = data.getKotaTujuan(i).ChildNodes.Count;
				int j=0;
				if(jumlahTujuan>0){
					for(j=0;j<jmlKota;j++){
						matriks[i,j]=-1;
					}
					
					for(j=0;j<jumlahTujuan;j++){
						int indexs=Convert.ToInt32(data.getKotaTujuan(i).ChildNodes[j].Name);
						int isi = Convert.ToInt32(data.getKotaTujuan(i).ChildNodes[j].InnerText);
						matriks[i,indexs]=isi;
					}
					
					
					
				}else{
					for(;j<jmlKota;j++){
						matriks[i,j]=-1;
					}
				}
				
				matriks[i,i]=0;
				
			}
			
			return matriks;
			
		}
		
		private void populateCB(){
			
			for(int i=0;i<this.data.getJumlahKota();i++){
				cb_awal.Items.Add(i);
			}
		}
		
		private void DijkstraCoreCalculation(int awal){
			int panjangN=this.Matriks.GetLength(0);
			int kotaAwalTidakPunyaTujuan= 0;
			
			for(int i=0;i<panjangN;i++){
				this.Simpul[i]=0;
				this.d[i]=this.Matriks[awal,i];
				this.Rute[i]=awal.ToString()+" ";
				if(d[i]==-1)kotaAwalTidakPunyaTujuan++;
				
			}
			
			this.Simpul[awal]=1;
			this.d[awal]=-1;
			
			
			if(kotaAwalTidakPunyaTujuan<panjangN-1){ //kota awal harus tidak terpencil dan ada jalur keluar maka
				
				for(int k=1;k<panjangN;k++){
					
					
					
					//cari minimal dari reachable point
					int minimalIndexs=0;
					int j,foundIndexpertama=0;
					
					
					for(j=0;j<panjangN;j++){
						
						//yang simpul=0 dan dj terjamah alias tidak bernilai -1
						if(this.Simpul[j]==0){
							if(this.d[j]!=-1){
								if(foundIndexpertama==0){
									minimalIndexs=j;
									foundIndexpertama=1;
								}
								
								if(this.d[j]<this.d[minimalIndexs]){
									minimalIndexs=j;
									
								}
							}
							
						}
						
					}
					j=minimalIndexs;
					
					this.Simpul[j]=1;
					
					//update table d atau array d
					for(int i=0;i<panjangN;i++){
						if(this.Simpul[i]==0){
							if(this.Matriks[j,i]!=-1){
								if(this.d[i]!=-1){
									if(this.d[j]+this.Matriks[j,i]<this.d[i]){
										
										this.d[i]=this.d[j]+this.Matriks[j,i];
										
									}
								}else{
									this.d[i]=this.d[j]+this.Matriks[j,i];
									
								}
							}
						}
						
					}
					
					
					
				}
				
			}
				
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try{
				int awal=Convert.ToInt32(this.cb_awal.Text);
				String hasilPerhitungan="";
				this.sw.Reset();
          		datadarixml.Text=parseXML();
         //--------------------------------------------------------- 		
            this.sw.Start();       
             
				DijkstraCoreCalculation(awal);				
				for(int i=0;i<this.d.Length;i++){
					if(i!=awal && d[i]!=-1)
						hasilPerhitungan+="\nJarak terpendek dari "+awal+" ke "+i+" adalah "+d[i].ToString()+" Km ";
				}
				if(hasilPerhitungan=="")
					datadarixml.Text+="\nKota "+awal+" Terpencil tidak ada jalan keluar dari kota ini\n";
				else
					datadarixml.Text+=hasilPerhitungan;				
			this.sw.Stop();
		//----------------------------------------------------------	
			double ticks = sw.ElapsedTicks/10000;
			
			
			datadarixml.Text+="\nWaktu eksekusi : "+ticks.ToString()+" milisecond";
			datadarixml.Text+="\nKompleksitas waktu : \n"+
				"T(n)=O(n)+n-2[O(n)+O(N)]\n"+
				"T(n)=O(n)+n-2.O(n)\n"+
				"T(n)=O(n)+O(n Pangkat 2)"+
				"T(n)=O(n pangkat 2)";
			
			}catch(FormatException){
				MessageBox.Show("Silahkan Pilih Kota Keberangkatan");
			}catch(Exception exc){
				MessageBox.Show(exc.Message);
			}
			
				
		}

        private void cb_awal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
	}
}
