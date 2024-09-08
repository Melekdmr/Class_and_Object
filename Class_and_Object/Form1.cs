using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_and_Object
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Araba arb = new Araba();
			arb.renk = "blue";
			arb.hiz = 160;
			arb.motor = 1245.56;
			arb.fiyat = 50000;
			arb.durum = 's';


			label1.Text = arb.renk;
			label2.Text = arb.hiz.ToString();
			label3.Text = arb.motor.ToString();
			label4.Text = arb.fiyat.ToString();
			label5.Text = arb.durum.ToString();

			pictureBox1.BackColor = Color.CadetBlue;

		}
	}
}
