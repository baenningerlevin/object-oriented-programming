namespace WhileLoop
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // while Loop
      int i = 1, sum = 0;

      while (i <= 5)
      {
        sum += i;
        i++;
      }
      Console.WriteLine("Sum = {0}", sum);

      // do-while Loop
      int j = 1, n = 5, product;

      do
      {
        product = n * j;
        Console.WriteLine("{0} * {1} = {2}", n, j, product);
        j++;
      } while (j <= 10);

      Console.ReadKey();
    }
  }
}
