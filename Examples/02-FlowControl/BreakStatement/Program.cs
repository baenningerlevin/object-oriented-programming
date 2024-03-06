namespace BreakStatement
{
  internal class Program
  {
    static void Main(string[] args)
    {
      for (int i = 1; i <= 4; ++i)
      {
        // terminates the loop
        if (i == 3)
        {
          break;
        }

        Console.WriteLine(i);
      }

      Console.ReadKey();
    }
  }
}
