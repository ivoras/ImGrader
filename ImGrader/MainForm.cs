/*
 * Created by SharpDevelop.
 * User: ivoras
 * Date: 05.12.2016.
 * Time: 19:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImGrader
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		List<ImageFile> ifiles = new List<ImageFile>();
		int current_index = -1;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (fbrowser.ShowDialog() != DialogResult.OK)
				return;
			ifiles = ImageFile.getFilesInDir(fbrowser.SelectedPath);
			if (ifiles.Count > 1) {
				current_index = 0;
				showCurrentIndexImage();
			}
		}
		
		private void showCurrentIndexImage() {
			if (current_index < 0 || current_index > ifiles.Count-1)
				return;
			if (pbox.Image != null)
				pbox.Image.Dispose();
			pbox.Image = Image.FromFile(ifiles[current_index].fi.FullName);
			if (pbox.Image.Width < this.Width && pbox.Image.Height < this.Height) {
				pbox.SizeMode = PictureBoxSizeMode.CenterImage;
			} else {
				pbox.SizeMode = PictureBoxSizeMode.Zoom;
			}
		}
		
	    protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
			//MessageBox.Show(this, "ke: " + keyData);
			if (keyData == Keys.Right) {
				current_index++;
				if (current_index >= ifiles.Count)
					current_index = 0;
				showCurrentIndexImage();
			} else if (keyData == Keys.Left) {
				current_index--;
				if (current_index < 0)
					current_index = ifiles.Count - 1;
				showCurrentIndexImage();
			}
	        return base.ProcessCmdKey(ref msg, keyData);
	    }
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
		}
		
		void MainFormPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
		}
	}
}
