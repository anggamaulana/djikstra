/*
 * Created by SharpDevelop.
 * User: Angga
 * Date: 07/04/2012
 * Time: 13:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace asaProj
{
	partial class jarakTerminal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.jaraktb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.indekskotaasal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jaraktb
            // 
            this.jaraktb.Location = new System.Drawing.Point(35, 32);
            this.jaraktb.Name = "jaraktb";
            this.jaraktb.Size = new System.Drawing.Size(92, 20);
            this.jaraktb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jarak dari kota indeks ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // indekskotaasal
            // 
            this.indekskotaasal.Location = new System.Drawing.Point(150, 6);
            this.indekskotaasal.Name = "indekskotaasal";
            this.indekskotaasal.Size = new System.Drawing.Size(66, 23);
            this.indekskotaasal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(133, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Km";
            // 
            // jarakTerminal
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 144);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.indekskotaasal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jaraktb);
            this.Name = "jarakTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jarakTerminal";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label indekskotaasal;
		private System.Windows.Forms.TextBox jaraktb;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}
