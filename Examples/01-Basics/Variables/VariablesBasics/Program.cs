using System;

namespace VariablesBasics
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      const string characterName = "John";
      int characterAge;

      // Initialize the variables
      characterAge = 35;

      // Declare and initialize the variables
      string characterJob = "Programmer";

      // Print the variables
      Console.WriteLine($"{characterName} is {characterAge} years old and is a {characterJob}");

      // Change the variables
      // characterName = "Tom"; // This will throw an error
      characterAge = 25;
      characterJob = "Teacher";

      Console.Write("\nNew values:\n");
      Console.WriteLine($"{characterName} is {characterAge} years old and is a {characterJob}");

      Console.ReadKey();
    }
  }
}