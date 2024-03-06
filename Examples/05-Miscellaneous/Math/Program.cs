namespace MathLibrary
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Math.Max()
      Console.WriteLine(Math.Max(5, 10)); // 10

      // Math.Min()
      Console.WriteLine(Math.Min(5, 10)); // 5

      // Math.Pow()
      Console.WriteLine(Math.Pow(2, 3)); // 8

      // Math.Sqrt()
      Console.WriteLine(Math.Sqrt(25)); // 5

      // Math.Round()
      Console.WriteLine(Math.Round(10.75)); // 11

      // Math.Floor()
      Console.WriteLine(Math.Floor(10.85)); // 10

      // Math.Ceiling()
      Console.WriteLine(Math.Ceiling(10.15)); // 11

      // Math.Abs()
      Console.WriteLine(Math.Abs(-10)); // 10

      Console.ReadKey();
    }
  }
}
