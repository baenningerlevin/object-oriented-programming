using System;

namespace RelationalOperators
{
  class Program
  {
    public static void Main(string[] args)
    {
      bool result;
      int firstNumber = 10, secondNumber = 20;

      result = (firstNumber == secondNumber);
      Console.WriteLine($"{firstNumber} == {secondNumber} returns {result}");

      result = (firstNumber > secondNumber);
      Console.WriteLine($"{firstNumber} > {secondNumber} returns {result}");

      result = (firstNumber < secondNumber);
      Console.WriteLine($"{firstNumber} < {secondNumber} returns {result}");

      result = (firstNumber >= secondNumber);
      Console.WriteLine($"{firstNumber} >= {secondNumber} returns {result}");

      result = (firstNumber <= secondNumber);
      Console.WriteLine($"{firstNumber} <= {secondNumber} returns {result}");

      result = (firstNumber != secondNumber);
      Console.WriteLine($"{firstNumber} != {secondNumber} returns {result}");

      Console.ReadKey();
    }
  }
}