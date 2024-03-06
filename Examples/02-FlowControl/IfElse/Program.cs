namespace IfElse
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // if-Statement
      Console.WriteLine("if-Statement");
      Console.WriteLine("----------------------------");
      int number = 2;
      if (number < 5)
      {
        Console.WriteLine("{0} is less than 5", number);
      }

      Console.WriteLine("This statement is always executed.\n");


      // if...else-Statement
      Console.WriteLine("if...else-Statement");
      Console.WriteLine("----------------------------");
      int number2 = 12;

      if (number2 < 5)
      {
        Console.WriteLine("{0} is less than 5", number2);
      }
      else
      {
        Console.WriteLine("{0} is greater than or equal to 5", number2);
      }

      Console.WriteLine("This statement is always executed.\n");

      // if...else if-Statement
      Console.WriteLine("if...else if-Statement");
      Console.WriteLine("----------------------------");
      int number3 = 12;

      if (number3 < 5)
      {
        Console.WriteLine("{0} is less than 5", number3);
      }
      else if (number3 > 5)
      {
        Console.WriteLine("{0} is greater than 5", number3);
      }
      else
      {
        Console.WriteLine("{0} is equal to 5");
      }

      Console.ReadKey();
    }
  }
}
