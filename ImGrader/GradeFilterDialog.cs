/*
 * Created by SharpDevelop.
 * User: ivoras
 * Date: 06.12.2016.
 * Time: 20:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImGrader
{
	/// <summary>
	/// Description of GradeFilterDialog.
	/// </summary>
	public partial class GradeFilterDialog : Form
	{
		public GradeFilterDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void setMinGrade(int mg) {
			minGrade.Value = mg;
		}
		
		public int getMinGrade() {
			return (int)(minGrade.Value);
		}
	}
}
