/*
 * Created by SharpDevelop.
 * User: CC2_PC35
 * Date: 21/11/2024
 * Time: 02:05 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace imagina_tapetes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			pagina2 pag = new pagina2();
			this.Hide();
			pag.ShowDialog();
			Close();
		}
	}
}
