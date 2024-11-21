/*
 * Created by SharpDevelop.
 * User: CC2_PC35
 * Date: 21/11/2024
 * Time: 02:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace imagina_tapetes
{
	/// <summary>
	/// Description of pagina2.
	/// </summary>
	public partial class pagina2 : Form
	{
		public pagina2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			precios pre = new precios();
			this.Hide();
			pre.ShowDialog();
			Close();
		}
	}
}
