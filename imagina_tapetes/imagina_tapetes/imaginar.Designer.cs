/*
 * Created by SharpDevelop.
 * User: CC2_PC35
 * Date: 21/11/2024
 * Time: 02:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace imagina_tapetes
{
	partial class imaginar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnacerrin = new System.Windows.Forms.Button();
			this.lblaserrin = new System.Windows.Forms.Label();
			this.lblcal = new System.Windows.Forms.Label();
			this.btncal = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblcemi = new System.Windows.Forms.Label();
			this.btnnatural = new System.Windows.Forms.Button();
			this.lblflor = new System.Windows.Forms.Label();
			this.lblherramientas = new System.Windows.Forms.Label();
			this.btnerra = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.lblmanoo = new System.Windows.Forms.Label();
			this.btnmano = new System.Windows.Forms.Button();
			this.LBLMANO = new System.Windows.Forms.Label();
			this.lbltinta = new System.Windows.Forms.Label();
			this.btntinta = new System.Windows.Forms.Button();
			this.btnlimpiar = new System.Windows.Forms.Button();
			this.btnimaginar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "KILOS DE ACERRIN";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(182, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "TINTA PARA ACERRIN";
			// 
			// btnacerrin
			// 
			this.btnacerrin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnacerrin.Location = new System.Drawing.Point(15, 157);
			this.btnacerrin.Name = "btnacerrin";
			this.btnacerrin.Size = new System.Drawing.Size(54, 56);
			this.btnacerrin.TabIndex = 11;
			this.btnacerrin.Text = "+";
			this.btnacerrin.UseVisualStyleBackColor = true;
			this.btnacerrin.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblaserrin
			// 
			this.lblaserrin.Location = new System.Drawing.Point(78, 159);
			this.lblaserrin.Name = "lblaserrin";
			this.lblaserrin.Size = new System.Drawing.Size(48, 53);
			this.lblaserrin.TabIndex = 12;
			this.lblaserrin.Text = "###";
			// 
			// lblcal
			// 
			this.lblcal.Location = new System.Drawing.Point(425, 158);
			this.lblcal.Name = "lblcal";
			this.lblcal.Size = new System.Drawing.Size(41, 53);
			this.lblcal.TabIndex = 15;
			this.lblcal.Text = "###";
			// 
			// btncal
			// 
			this.btncal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncal.Location = new System.Drawing.Point(362, 155);
			this.btncal.Name = "btncal";
			this.btncal.Size = new System.Drawing.Size(43, 56);
			this.btncal.TabIndex = 14;
			this.btncal.Text = "+";
			this.btncal.UseVisualStyleBackColor = true;
			this.btncal.Click += new System.EventHandler(this.BtncalClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(362, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 30);
			this.label4.TabIndex = 13;
			this.label4.Text = "ARENA O CAL";
			// 
			// lblcemi
			// 
			this.lblcemi.Location = new System.Drawing.Point(408, 285);
			this.lblcemi.Name = "lblcemi";
			this.lblcemi.Size = new System.Drawing.Size(48, 58);
			this.lblcemi.TabIndex = 18;
			this.lblcemi.Text = "###";
			// 
			// btnnatural
			// 
			this.btnnatural.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnnatural.Location = new System.Drawing.Point(362, 282);
			this.btnnatural.Name = "btnnatural";
			this.btnnatural.Size = new System.Drawing.Size(54, 61);
			this.btnnatural.TabIndex = 17;
			this.btnnatural.Text = "+";
			this.btnnatural.UseVisualStyleBackColor = true;
			this.btnnatural.Click += new System.EventHandler(this.BtnnaturalClick);
			// 
			// lblflor
			// 
			this.lblflor.Location = new System.Drawing.Point(362, 232);
			this.lblflor.Name = "lblflor";
			this.lblflor.Size = new System.Drawing.Size(87, 30);
			this.lblflor.TabIndex = 16;
			this.lblflor.Text = "FLORES, CEMILLAS ETC";
			// 
			// lblherramientas
			// 
			this.lblherramientas.Location = new System.Drawing.Point(61, 287);
			this.lblherramientas.Name = "lblherramientas";
			this.lblherramientas.Size = new System.Drawing.Size(48, 58);
			this.lblherramientas.TabIndex = 21;
			this.lblherramientas.Text = "###";
			// 
			// btnerra
			// 
			this.btnerra.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnerra.Location = new System.Drawing.Point(15, 285);
			this.btnerra.Name = "btnerra";
			this.btnerra.Size = new System.Drawing.Size(54, 61);
			this.btnerra.TabIndex = 20;
			this.btnerra.Text = "+";
			this.btnerra.UseVisualStyleBackColor = true;
			this.btnerra.Click += new System.EventHandler(this.BtnerraClick);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(15, 235);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(93, 30);
			this.label9.TabIndex = 19;
			this.label9.Text = "HERRAMIENTAS BASICAS";
			// 
			// lblmanoo
			// 
			this.lblmanoo.Location = new System.Drawing.Point(228, 285);
			this.lblmanoo.Name = "lblmanoo";
			this.lblmanoo.Size = new System.Drawing.Size(48, 58);
			this.lblmanoo.TabIndex = 27;
			this.lblmanoo.Text = "###";
			// 
			// btnmano
			// 
			this.btnmano.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnmano.Location = new System.Drawing.Point(182, 283);
			this.btnmano.Name = "btnmano";
			this.btnmano.Size = new System.Drawing.Size(54, 61);
			this.btnmano.TabIndex = 26;
			this.btnmano.Text = "+";
			this.btnmano.UseVisualStyleBackColor = true;
			this.btnmano.Click += new System.EventHandler(this.BtnmanoClick);
			// 
			// LBLMANO
			// 
			this.LBLMANO.Location = new System.Drawing.Point(182, 233);
			this.LBLMANO.Name = "LBLMANO";
			this.LBLMANO.Size = new System.Drawing.Size(65, 30);
			this.LBLMANO.TabIndex = 25;
			this.LBLMANO.Text = "MANO DE OBRA";
			// 
			// lbltinta
			// 
			this.lbltinta.Location = new System.Drawing.Point(237, 159);
			this.lbltinta.Name = "lbltinta";
			this.lbltinta.Size = new System.Drawing.Size(39, 53);
			this.lbltinta.TabIndex = 32;
			this.lbltinta.Text = "###";
			// 
			// btntinta
			// 
			this.btntinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btntinta.Location = new System.Drawing.Point(182, 157);
			this.btntinta.Name = "btntinta";
			this.btntinta.Size = new System.Drawing.Size(49, 56);
			this.btntinta.TabIndex = 31;
			this.btntinta.Text = "+";
			this.btntinta.UseVisualStyleBackColor = true;
			this.btntinta.Click += new System.EventHandler(this.BtntintaClick);
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlimpiar.Location = new System.Drawing.Point(15, 426);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(204, 69);
			this.btnlimpiar.TabIndex = 33;
			this.btnlimpiar.Text = "LIMPIAR";
			this.btnlimpiar.UseVisualStyleBackColor = true;
			this.btnlimpiar.Click += new System.EventHandler(this.LbllimpiarClick);
			// 
			// btnimaginar
			// 
			this.btnimaginar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnimaginar.Location = new System.Drawing.Point(262, 426);
			this.btnimaginar.Name = "btnimaginar";
			this.btnimaginar.Size = new System.Drawing.Size(204, 69);
			this.btnimaginar.TabIndex = 34;
			this.btnimaginar.Text = "IMAGINAR";
			this.btnimaginar.UseVisualStyleBackColor = true;
			this.btnimaginar.Click += new System.EventHandler(this.BtnimaginarClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(70, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(357, 34);
			this.label3.TabIndex = 35;
			this.label3.Text = "COMIENZA A IMAGINAR";
			// 
			// imaginar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(549, 534);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnimaginar);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.lbltinta);
			this.Controls.Add(this.btntinta);
			this.Controls.Add(this.lblmanoo);
			this.Controls.Add(this.btnmano);
			this.Controls.Add(this.LBLMANO);
			this.Controls.Add(this.lblherramientas);
			this.Controls.Add(this.btnerra);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lblcemi);
			this.Controls.Add(this.btnnatural);
			this.Controls.Add(this.lblflor);
			this.Controls.Add(this.lblcal);
			this.Controls.Add(this.btncal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblaserrin);
			this.Controls.Add(this.btnacerrin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "imaginar";
			this.Text = "imaginar";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnimaginar;
		private System.Windows.Forms.Button btnlimpiar;
		private System.Windows.Forms.Button btntinta;
		private System.Windows.Forms.Label LBLMANO;
		private System.Windows.Forms.Button btnmano;
		private System.Windows.Forms.Label lblmanoo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnerra;
		private System.Windows.Forms.Label lblherramientas;
		private System.Windows.Forms.Label lblflor;
		private System.Windows.Forms.Button btnnatural;
		private System.Windows.Forms.Label lblcemi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btncal;
		private System.Windows.Forms.Label lblcal;
		private System.Windows.Forms.Button btnacerrin;
		private System.Windows.Forms.Label lbltinta;
		private System.Windows.Forms.Label lblaserrin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
