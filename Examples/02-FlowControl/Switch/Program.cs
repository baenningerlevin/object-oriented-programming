using System;

namespace Switch
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double result = 0.0;

      Console.Write("Enter first number: ");
      double first = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter second number: ");
      double second = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter operator (+, -, *, /): ");
      char op = (char)Console.Read();

      switch (op)
      {
        case '+':
          result = first + second;
          Console.WriteLine("{0} + {1} = {2}", first, second, result);
          break;

        case '-':
          result = first - second;
          Console.WriteLine("{0} - {1} = {2}", first, second, result);
          break;

        case '*':
          result = first * second;
          Console.WriteLine("{0} * {1} = {2}", first, second, result);
          break;

        case '/':
          result = first / second;
          Console.WriteLine("{0} / {1} = {2}", first, second, result);
          break;

        default:
          Console.WriteLine("Invalid Operator");
          break;
      }

      Console.ReadKey();
    }
  }
}