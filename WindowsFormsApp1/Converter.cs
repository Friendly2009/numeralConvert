using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;
public class Converter
{
	public static string ConvertBase(string numberStr, int fromBase, int toBase)
	{
		BigInteger number = BigInteger.Zero;
		foreach (char c in numberStr)
		{
			int digit = CharToDigit(c);
			number = number * fromBase + digit;
		}
		if (number.IsZero)
		{
			return "0";
		}
		string result = "";
		BigInteger targetBase = toBase;
		while (number > 0)
		{
			BigInteger remainder = number % targetBase;
			result = DigitToChar((int)remainder) + result;
			number /= targetBase;
		}
		return result;
	}
	private static int CharToDigit(char c)
	{
		if (char.IsDigit(c))
		{
			return c - '0';
		}
		if (char.IsLetter(c))
		{
			return char.ToUpper(c) - 'A' + 10;
		}
		MessageBox.Show($"Недопустимый символ '{c}' в числе");
		return 0;
	}
	private static char DigitToChar(int digit)
	{
		if (digit >= 0 && digit <= 9)
		{
			return (char)('0' + digit);
		}
		return (char)('A' + digit - 10);
	}
	public static List<int> ConvertToList(string numberStr)
	{
		var digits = new List<int>();

		foreach (char c in numberStr)
		{
			switch (c)
			{
				case 'A':
					digits.Add(10);
					break;
				case 'B':
					digits.Add(11);
					break;
				case 'C':
					digits.Add(12);
					break;
				case 'D':
					digits.Add(13);
					break;
				case 'E':
					digits.Add(14);
					break;
				case 'F':
					digits.Add(15);
					break;
				case 'G':
					digits.Add(16);
					break;
				case 'H':
					digits.Add(17);
					break;
				case 'I':
					digits.Add(18);
					break;
				case 'J':
					digits.Add(19);
					break;
				case 'K':
					digits.Add(20);
					break;
				case 'L':
					digits.Add(21);
					break;
				case 'M':
					digits.Add(22);
					break;
				case 'N':
					digits.Add(23);
					break;
				case 'O':
					digits.Add(24);
					break;
				case 'P':
					digits.Add(25);
					break;
				case 'Q':
					digits.Add(26);
					break;
				case 'R':
					digits.Add(27);
					break;
				case 'S':
					digits.Add(28);
					break;
				case 'T':
					digits.Add(29);
					break;
				case 'U':
					digits.Add(30);
					break;
				case 'V':
					digits.Add(31);
					break;
				default:
					digits.Add(c - '0');
					break;
			}
		}
		return digits;
	}
}
