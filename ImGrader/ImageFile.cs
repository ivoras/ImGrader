/*
 * Created by SharpDevelop.
 * User: ivoras
 * Date: 05.12.2016.
 * Time: 19:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace ImGrader
{
	/// <summary>
	/// Description of ImageFile.
	/// </summary>
	public class ImageFile
	{
		public string name;
		public int grade;
		public FileInfo fi;
		
		public ImageFile(string _name, int _grade, FileInfo _fi)
		{
			name = _name;
			grade = _grade;
			fi = _fi;
		}
		
		
		public static List<ImageFile> getFilesInDir(string dir) {
			var ilist = new List<ImageFile>();
			foreach (string fn in Directory.GetFiles(dir)) {
				var fi = new FileInfo(fn);
				var ext = fi.Extension.ToLower();
				if (ext != ".jpg" && ext != ".jpeg" && ext != ".png")
					continue;
				
				var imf = new ImageFile(fn, 0, fi);
				ilist.Add(imf);
			}
			
			foreach (string fn in Directory.GetDirectories(dir)) {
				var fi = new FileInfo(fn);
				if (fi.Name == "1" || fi.Name == "2" || fi.Name == "3" || fi.Name == "4" || fi.Name == "5") {
					// Pick up the already graded files in the directory
					foreach (string fn1 in Directory.GetFiles(fi.FullName)) {
						var fi1 = new FileInfo(fn1);
						var ext = fi1.Extension.ToLower();
						if (ext != ".jpg" && ext != ".jpeg" && ext != ".png")
							continue;
						var imf1 = new ImageFile(fn1, int.Parse(fi.Name), fi1);
						ilist.Add(imf1);
					}
				}
			}
			
			
			ilist.Sort((a,b) => a.fi.CreationTimeUtc.CompareTo(b.fi.CreationTimeUtc));
			
			return ilist;
		}
		
		public void moveGrade(string main_dir, int new_grade) {
			string new_file;
			if (new_grade > 0) {
				string new_dir = main_dir + "\\" + new_grade;
				if (!Directory.Exists(new_dir))
					Directory.CreateDirectory(new_dir);
				new_file = new_dir + "\\" + fi.Name;
			} else
				new_file = main_dir + "\\" + fi.Name;
			fi.MoveTo(new_file);
			name = new_file;
			fi = new FileInfo(new_file);
			grade = new_grade;
		}
		
		public static void filterMinGrade(ref List<ImageFile> ifiles, int min_grade) {
			var ofiles = new List<ImageFile>();
			foreach (ImageFile i in ifiles) {
				if (i.grade >= min_grade)
					ofiles.Add(i);
			}
			ifiles = ofiles;
		}
	}
}
