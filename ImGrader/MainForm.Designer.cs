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
		private System.Windows.Forms.Label lbGrade;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label label1;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pbox = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.fbrowser = new System.Windows.Forms.FolderBrowserDialog();
			this.lbGrade = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.label1 = new System.Windows.Forms.Label();
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
			this.button1.TabStop = false;
			this.toolTip.SetToolTip(this.button1, "Open a folder with images");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// fbrowser
			// 
			this.fbrowser.Description = "Choose a folder with images";
			// 
			// lbGrade
			// 
			this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbGrade.Location = new System.Drawing.Point(66, 12);
			this.lbGrade.Name = "lbGrade";
			this.lbGrade.Size = new System.Drawing.Size(119, 25);
			this.lbGrade.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(12, 66);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 48);
			this.button2.TabIndex = 3;
			this.button2.TabStop = false;
			this.button2.Text = "0";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.toolTip.SetToolTip(this.button2, "Filter and show only images above a certain grade");
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(66, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 23);
			this.label1.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 420);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.lbGrade);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pbox);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
