using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void MainButton_Click(object sender, EventArgs e)
		{

		}
		public static List<int> ConvertToList(int number)
		{
			var digits = new List<int>();
			string numberStr = number.ToString();

			foreach (char c in numberStr)
			{
				digits.Add(c - '0');
			}
			return digits;
		}
		static string ConvertToBase(int number, int radix)
		{
			const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			if (radix < 2 || radix > chars.Length)
			{
				MessageBox.Show("максимум было 16");
			}
			if (number == 0) { return "0"; }
			string result = "";
			int current = number;
			while (current > 0)
			{
				int remainder = current % radix;
				result = chars[remainder] + result;
				current /= radix;
			}
			return result;
		}
	}
}
