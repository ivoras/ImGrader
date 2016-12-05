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
				
				if ( (fi.Attributes & FileAttributes.Directory) == FileAttributes.Directory) {
					if (fi.Name == "1" || fi.Name == "2" || fi.Name == "3" || fi.Name == "4" || fi.Name == "5") {
						// Pick up the already graded files in the directory
						foreach (string fn1 in Directory.GetFiles(fi.FullName)) {
							var fi1 = new FileInfo(fn1);
							if (fi1.Extension != ".jpg" && fi1.Extension != ".jpeg" && fi1.Extension != ".png")
								continue;
							var imf1 = new ImageFile(fn1, int.Parse(fi.Name), fi1);
							ilist.Add(imf1);
						}
					}
				}
				
				if (fi.Extension != ".jpg" && fi.Extension != ".jpeg" && fi.Extension != ".png")
					continue;
				
				var imf = new ImageFile(fn, 0, fi);
				ilist.Add(imf);
			}
			
			ilist.Sort((a,b) => a.fi.LastWriteTimeUtc.CompareTo(b.fi.LastWriteTimeUtc));
			
			return ilist;
		}
	}
}
