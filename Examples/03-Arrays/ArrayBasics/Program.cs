namespace ArrayBasics
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // declare array
      int[] ages = new int[5];
      Console.WriteLine(ages.Length);

      // initialize array
      ages[0] = 3;
      ages[1] = 5;
      ages[2] = 7;

      int[] numbers = [1, 2, 3, 4, 5];

      // access array elements
      int first = numbers[0];
      int last = numbers[numbers.Length - 1];

      Console.WriteLine(first);
      Console.WriteLine(last);

      // change array elements
      ages[2] = 4;
      Console.WriteLine(ages[2]);

      // iterate over array
      for (int i = 0; i < numbers.Length; i++)
      {
        int number = numbers[i];
        Console.WriteLine(number);
      }

      Console.ReadKey();
    }
  }
}
