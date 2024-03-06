using System;

namespace Conversion
{
  class Program
  {
    static void Main(string[] args)
    {
      // create int variable
      int num = 100;
      Console.WriteLine("int value: " + num);

      // convert int to string
      string str = Convert.ToString(num);
      Console.WriteLine("string value: " + str);

      // convert int to Double
      double doubleNum = Convert.ToDouble(num);
      Console.WriteLine("double value: " + doubleNum);

      Console.ReadKey();
    }
  }
}