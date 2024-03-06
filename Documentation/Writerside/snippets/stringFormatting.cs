using System;

namespace Output
{
	class StringFormatting
	{
		public static void Main(string[] args)
		{
			int firstNumber = 5, secondNumber = 10, result;
			result = firstNumber + secondNumber;

			Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

			Console.ReadKey();
		}
	}
}