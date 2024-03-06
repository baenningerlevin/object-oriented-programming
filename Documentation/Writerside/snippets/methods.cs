using System;

namespace Method
{
  class Program
  {
    int addNumber (int a, int b)
    {
      int sum = a + b;
      return sum;
    }

    static void Main(string[] args)
    {
      // create class object
      Program p1 = new Program();

      //call method
      int sum = p1.addNumber(100,100);

      Console.WriteLine("Sum: " + sum);

      Console.ReadKey();
    }
  }
}