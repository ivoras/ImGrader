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
using ExifLib;

namespace ImGrader
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		List<ImageFile> ifiles = new List<ImageFile>();
		int current_index = -1;
		string main_dir = "";
		int min_grade = 0;

		
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
			loadDirImages(fbrowser.SelectedPath);
		}
		
		private void loadDirImages(string dir) {
			main_dir = dir;
			ifiles = ImageFile.getFilesInDir(main_dir);
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
			var fn = ifiles[current_index].fi.FullName;
			var exif = new ExifReader(fn);
			var img = Image.FromFile(fn);
			
			UInt16 orientation;
			if (exif.GetTagValue<UInt16>(ExifTags.Orientation, out orientation)) {
				UInt32 iso;
				if (exif.GetTagValue<UInt32>(ExifTags.ISOSpeed, out iso))
					label1.Text = "ISO " + iso;
				switch (orientation) {
					case 3:
						img.RotateFlip(RotateFlipType.Rotate180FlipNone);
						break;
					case 6:
						img.RotateFlip(RotateFlipType.Rotate90FlipNone);
						break;
					case 8:
						img.RotateFlip(RotateFlipType.Rotate270FlipNone);
						break;
				}
			}
			
			pbox.Image = img;
			if (img.Width < this.Width && img.Height < this.Height) {
				pbox.SizeMode = PictureBoxSizeMode.CenterImage;
			} else {
				pbox.SizeMode = PictureBoxSizeMode.Zoom;
			}
			lbGrade.Text = new String('★', ifiles[current_index].grade);
			this.Text = ifiles[current_index].fi.Name + " ## " + (current_index + 1) + " / " + (ifiles.Count + 1);
			
			exif.Dispose();
		}
		
	    protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
			//MessageBox.Show(this, "ke: " + keyData);
			if (keyData == Keys.Right) {
				current_index++;
				if (current_index >= ifiles.Count)
					current_index = 0;
				showCurrentIndexImage();
				return true;
			} else if (keyData == Keys.Left) {
				current_index--;
				if (current_index < 0)
					current_index = ifiles.Count - 1;
				showCurrentIndexImage();
				return true;
			} else if (keyData == Keys.Up) {
				if (ifiles[current_index].grade < 5) {
					if (pbox.Image != null)
						pbox.Image.Dispose();
					ifiles[current_index].moveGrade(main_dir, ifiles[current_index].grade + 1);
					showCurrentIndexImage();
				}
				showCurrentIndexImage();
				return true;
			} else if (keyData == Keys.Down) {
				if (ifiles[current_index].grade > 0) {
					if (pbox.Image != null)
						pbox.Image.Dispose();
					ifiles[current_index].moveGrade(main_dir, ifiles[current_index].grade - 1);
					showCurrentIndexImage();
				}
				showCurrentIndexImage();
				return true;
			} else if (keyData == Keys.PageUp) {
				current_index += 100;
				if (current_index >= ifiles.Count) {
					current_index = ifiles.Count-1;
				}
				showCurrentIndexImage();
				return true;
			} else if (keyData == Keys.PageDown) {
				current_index -= 100;
				if (current_index < 0) {
					current_index = 0;
				}
				showCurrentIndexImage();
				return true;
			}
	        return base.ProcessCmdKey(ref msg, keyData);
	    }
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
		}
		
		void MainFormPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			var gfd = new GradeFilterDialog();
			gfd.setMinGrade(min_grade);
			if (gfd.ShowDialog() == DialogResult.OK) {
				min_grade = gfd.getMinGrade();
				loadDirImages(main_dir);
				ImageFile.filterMinGrade(ref ifiles, min_grade);
				current_index = 0;
				showCurrentIndexImage();
				button2.Text = min_grade.ToString();
			}
		}
	}
}
