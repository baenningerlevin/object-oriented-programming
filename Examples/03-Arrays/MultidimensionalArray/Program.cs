namespace MultidimensionalArray
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // declare a 2d array
      int[,] arr = new int[2, 3];

      // initialize the array
      arr[0, 0] = 1;
      arr[0, 1] = 2;
      arr[0, 2] = 3;
      int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 } };
      int[,] arr3 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

      // access elements in the array
      Console.WriteLine(arr2[0, 0]); // 1
      Console.WriteLine(arr2[1, 2]); // 6
      Console.WriteLine(arr2[0, 2]); // 3

      // iterate over the array
      int[,] numbers = { { 2, 3, 9 }, { 4, 5, 9 } };

      for (int i = 0; i < numbers.GetLength(0); i++)
      {
        Console.Write("Row " + i + ": ");

        for (int j = 0; j < numbers.GetLength(1); j++)
        {
          Console.Write(numbers[i, j] + " ");

        }
      }

      Console.ReadKey();
    }
  }
}
