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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			Araba arb2 = new Araba();
			arb2.renk = "red";
			arb2.hiz = 150;
			arb2.motor = 1585.76;
			arb2.fiyat = 80000;
			arb2.durum = 'i';


		}
		

	}
}
