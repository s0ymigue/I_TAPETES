/*
 * Created by SharpDevelop.
 * User: CC2_PC35
 * Date: 21/11/2024
 * Time: 02:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace imagina_tapetes
{
	/// <summary>
	/// Description of imaginar.
	/// </summary>
	public partial class imaginar : Form
	{
		private int ClickCount1 = 0;
		private int ClickCount2 = 0;
		private int ClickCount3 = 0;
		private int ClickCount4 = 0;
		private int ClickCount5 = 0;
		private int ClickCount6 = 0;
		int aserrin = 0;
		int erra = 0;
		int tinta = 0;
		int mano = 0;
		int cal = 0;
		int cemillas = 0;
		public imaginar()
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
			ClickCount1++;
			lblaserrin.Text=ClickCount1.ToString();
			aserrin=int.Parse(lblaserrin.Text);
		}
		
		void BtnerraClick(object sender, EventArgs e)
		{
			ClickCount2++;
			lblherramientas.Text=ClickCount2.ToString();
			erra = int.Parse(lblherramientas.Text);
		}
		
		void BtntintaClick(object sender, EventArgs e)
		{
			ClickCount3++;
			lbltinta.Text=ClickCount3.ToString();
			tinta = int.Parse(lbltinta.Text);
		}
		
		void BtnmanoClick(object sender, EventArgs e)
		{
			ClickCount4++;
			lblmanoo.Text=ClickCount4.ToString();
			mano = int.Parse(lblmanoo.Text);
		}
		
		void BtncalClick(object sender, EventArgs e)
		{
			ClickCount5++;
			lblcal.Text=ClickCount5.ToString();
			cal = int .Parse(lblcal.Text);
		}
		
		void BtnnaturalClick(object sender, EventArgs e)
		{
			ClickCount6++;
			lblcemi.Text=ClickCount6.ToString();
			cemillas = int.Parse(lblcemi.Text);
		}
		
		void LbllimpiarClick(object sender, EventArgs e)
		{
			lblaserrin.Text="####";
			lblcal.Text="####";
			lblcemi.Text="####";
			lbltinta.Text="####";
			lblherramientas.Text="####";
			lblmanoo.Text="####";
		}
		
		void BtnimaginarClick(object sender, EventArgs e)
		{
			final fin = new final(aserrin, erra, tinta, mano, cal, cemillas);
			this.Hide();
			fin.ShowDialog();
			Close();
		}
	}
}
