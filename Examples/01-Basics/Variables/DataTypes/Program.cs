using System;

namespace DataTypes
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Boolean
      bool isValid = true;
      Console.WriteLine(isValid);

      // sbyte (signed byte)
      sbyte level = 23;
      Console.WriteLine(level);

      // short
      short value = -1109;
      Console.WriteLine(value);

      // int
      int score = 51092;
      Console.WriteLine(score);

      // long
      long range = -7091821871L;
      Console.WriteLine(range);

      // byte
      byte age = 62;
      Console.WriteLine(age);

      // ushort (unsigned short)
      ushort steps = 42019;
      Console.WriteLine(steps);

      // uint (unsigned int)
      uint totalScore = 1151092;
      Console.WriteLine(totalScore);

      // ulong (unsigned long)
      ulong geoData = 17091821871L;
      Console.WriteLine(geoData);

      // float
      float distance = 1.5f;
      Console.WriteLine(distance);

      // double
      double pi = 3.14159265359;
      Console.WriteLine(pi);

      // char
      char letterB = '\u0042';
      char letterX = 'x';
      Console.WriteLine(letterB);
      Console.WriteLine(letterX);

      //string
      string firstName = "John";
      string lastName = "Doe";
      Console.WriteLine(firstName + " " + lastName);

      // decimal
      decimal price = 1.99m;
      Console.WriteLine(price);

      Console.ReadKey();
    }
  }
}