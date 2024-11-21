/*
 * Created by SharpDevelop.
 * User: CC2_PC35
 * Date: 21/11/2024
 * Time: 02:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace imagina_tapetes
{
	/// <summary>
	/// Description of precios.
	/// </summary>
	public partial class precios : Form
	{
		public precios()
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
			imaginar ima = new imaginar();
			this.Hide();
			ima.ShowDialog();
			Close();
		}
	}
}
