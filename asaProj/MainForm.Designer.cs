/*
 * Created by SharpDevelop.
 * User: Angga
 * Date: 02/04/2012
 * Time: 18:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace asaProj
{
	partial class MainForm
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
			this.lingkaran = new System.Windows.Forms.Button();
			this.garis = new System.Windows.Forms.Button();
			this.area = new System.Windows.Forms.PictureBox();
			this.reset = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.jmlkota = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.area)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lingkaran
			// 
			this.lingkaran.Location = new System.Drawing.Point(12, 38);
			this.lingkaran.Name = "lingkaran";
			this.lingkaran.Size = new System.Drawing.Size(75, 23);
			this.lingkaran.TabIndex = 0;
			this.lingkaran.Text = "Lingkaran";
			this.lingkaran.UseVisualStyleBackColor = true;
			this.lingkaran.Click += new System.EventHandler(this.LingkaranClick);
			// 
			// garis
			// 
			this.garis.Location = new System.Drawing.Point(120, 38);
			this.garis.Name = "garis";
			this.garis.Size = new System.Drawing.Size(75, 23);
			this.garis.TabIndex = 1;
			this.garis.Text = "Garis";
			this.garis.UseVisualStyleBackColor = true;
			this.garis.Click += new System.EventHandler(this.GarisClick);
			// 
			// area
			// 
			this.area.BackColor = System.Drawing.SystemColors.Control;
			this.area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.area.Location = new System.Drawing.Point(12, 81);
			this.area.Name = "area";
			this.area.Size = new System.Drawing.Size(615, 355);
			this.area.TabIndex = 2;
			this.area.TabStop = false;
			this.area.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AreaMouseDown);
			this.area.Paint += new System.Windows.Forms.PaintEventHandler(this.AreaPaint);
			this.area.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AreaMouseUp);
			// 
			// reset
			// 
			this.reset.Location = new System.Drawing.Point(230, 38);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(75, 23);
			this.reset.TabIndex = 3;
			this.reset.Text = "Reset";
			this.reset.UseVisualStyleBackColor = true;
			this.reset.Click += new System.EventHandler(this.ResetClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 448);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "Jumlah Kota :";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(258, 443);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// jmlkota
			// 
			this.jmlkota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jmlkota.Location = new System.Drawing.Point(93, 450);
			this.jmlkota.Name = "jmlkota";
			this.jmlkota.Size = new System.Drawing.Size(47, 18);
			this.jmlkota.TabIndex = 7;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(639, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 496);
			this.Controls.Add(this.jmlkota);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.reset);
			this.Controls.Add(this.area);
			this.Controls.Add(this.garis);
			this.Controls.Add(this.lingkaran);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dijkstra Algorithm";
			((System.ComponentModel.ISupportInitialize)(this.area)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label jmlkota;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button reset;
		private System.Windows.Forms.PictureBox area;
		private System.Windows.Forms.Button lingkaran;
		private System.Windows.Forms.Button garis;
	}
}
