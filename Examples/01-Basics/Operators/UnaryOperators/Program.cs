using System;

namespace UnaryOperators
{
  class Program
  {
    public static void Main(string[] args)
    {
      int number = 10, result;
      bool flag = true;

      result = +number;
      Console.WriteLine($"+number = {result}");

      result = -number;
      Console.WriteLine($"-number = {result}");

      result = ++number;
      Console.WriteLine($"++number = {result}");

      result = --number;
      Console.WriteLine($"--number = {result}");

      Console.WriteLine($"!flag = {!flag}");

      // Pre- vs Postfix

      Console.WriteLine((number++));
      Console.WriteLine((number));

      Console.WriteLine((++number));
      Console.WriteLine((number));

      Console.ReadKey();
    }
  }
}