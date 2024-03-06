using System;
 
namespace Output
{
	class PrintVariablesLiterals
	{
		public static void Main(string[] args)
		{
			int value = 10;

			// Variable
			Console.WriteLine(value);

			// Literal
			Console.WriteLine(50.05);

			Console.ReadKey();
		}
	}
}