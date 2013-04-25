/*
 * Created by SharpDevelop.
 * User: Angga
 * Date: 08/04/2012
 * Time: 18:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace asaProj
{
	partial class Simulasi
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datadarixml = new System.Windows.Forms.RichTextBox();
            this.cb_awal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cari Jalan Tercepat ke Semua Kota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kota Keberangkatan";
            // 
            // datadarixml
            // 
            this.datadarixml.Location = new System.Drawing.Point(12, 12);
            this.datadarixml.Name = "datadarixml";
            this.datadarixml.Size = new System.Drawing.Size(531, 284);
            this.datadarixml.TabIndex = 4;
            this.datadarixml.Text = "";
            // 
            // cb_awal
            // 
            this.cb_awal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_awal.FormattingEnabled = true;
            this.cb_awal.Location = new System.Drawing.Point(127, 318);
            this.cb_awal.Name = "cb_awal";
            this.cb_awal.Size = new System.Drawing.Size(58, 21);
            this.cb_awal.TabIndex = 5;
            this.cb_awal.SelectedIndexChanged += new System.EventHandler(this.cb_awal_SelectedIndexChanged);
            // 
            // Simulasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 418);
            this.Controls.Add(this.cb_awal);
            this.Controls.Add(this.datadarixml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Simulasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulasi";
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.ComboBox cb_awal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox datadarixml;
	}
}
