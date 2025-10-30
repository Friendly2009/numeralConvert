using System;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			ChooseFirst.DropDownStyle = ComboBoxStyle.DropDownList;
			ChooseLast.DropDownStyle = ComboBoxStyle.DropDownList;
		}
		private void MainButton_Click_1(object sender, EventArgs e)
		{
			if (ChooseFirst.Text != "" && ChooseLast.Text != "")
			{
				try
				{
					string num = input.Text;
					int first = int.Parse(ChooseFirst.Text);
					int last = int.Parse(ChooseLast.Text);
					var objec = Converter.ConvertToList(num.ToString());
					for (int i = 0; i < objec.Count; i++)
					{
						if (objec[i] >= first)
						{
							result.Text = "введите число, входящее в систему счисления";
							MessageBox.Show("введите число, входящее в систему счисления");
							return;
						}
					}
					if (first != last)
					{
						result.Text = Converter.ConvertBase(num.ToString(), first, last);
					}
					else
					{
						result.Text = "введите разные значения системы счислений";
						MessageBox.Show("введите разные значения системы счислений");
					}
				}
				catch
				{
					result.Text = "введите целое число";
					MessageBox.Show("введите целое число");
				}
			}
		}
	}
}
