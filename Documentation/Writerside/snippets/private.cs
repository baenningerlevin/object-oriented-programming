using System;

namespace MyApplication
{
  class Student
  {
    private string _name = "Sheeran";

    private void _print()
    {
      Console.WriteLine("Hello from Student class");
     }
  }

  class Program
  {
    static void Main(string[] args)
    {
      // creating object of Student class
      Student student1 = new Student();

      // accessing name field and printing it
      Console.WriteLine("Name: " + student1._name);

      // accessing print method from Student
      student1._print();

      Console.ReadKey();
    }
  }
}