using System;

namespace Conversion
{
  class Program
  {

    static void Main(string[] args)
    {

      string num1 = "100";

      // converting string to int type
      int num2 = int.Parse(num1);
      Console.WriteLine("Original string value: " + num1);
      Console.WriteLine("Converted int value: " + num2);

      Console.ReadKey();
    }
  }
}