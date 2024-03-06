using System;

namespace MyApplication
{
  class Student
  {
    public string Name = "Sheeran";

    public void Print()
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
      Console.WriteLine("Name: " + student1.Name);

      // accessing print method from Student
      student1.Print();

      Console.ReadKey();
    }
  }
}