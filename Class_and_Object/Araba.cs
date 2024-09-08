using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_and_Object
{
	internal class Araba
	{
		public string renk;
		public int hiz;
		public double motor;
		public char durum;
		public int fiyat;
		private int yıl;
		private string Marka;


		public int YIL
		{
			get { return yıl; }
			set { yıl = Math.Abs(value); }

		}
		public string MARKASI
		{
			get { return Marka; }
			set { Marka = value.ToUpper(); }
		}
	}
}
