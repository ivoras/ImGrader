/*
 * Created by SharpDevelop.
 * User: ivoras
 * Date: 05.12.2016.
 * Time: 19:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ImGrader
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pbox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FolderBrowserDialog fbrowser;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pbox = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.fbrowser = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
			this.SuspendLayout();
			// 
			// pbox
			// 
			this.pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbox.Location = new System.Drawing.Point(0, 0);
			this.pbox.Name = "pbox";
			this.pbox.Size = new System.Drawing.Size(778, 420);
			this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbox.TabIndex = 0;
			this.pbox.TabStop = false;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 48);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 420);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pbox);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ImGrader";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainFormPreviewKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
