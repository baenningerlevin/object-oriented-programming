using System;

namespace InputOutpu
{
  class Program
  {
    static void Main(string[] args)
    {
      // Output
      Console.WriteLine("Prints on ");
      Console.WriteLine("New line");

      Console.Write("Prints on ");
      Console.Write("Same line");

      // Outputting variables
      int value = 10;
      Console.WriteLine("Value is " + value);
      Console.WriteLine("Value is {0}", value);
      Console.WriteLine($"Value is {value}");

      // Input
      Console.WriteLine("Enter your name: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello {name}");
    }
  }
}