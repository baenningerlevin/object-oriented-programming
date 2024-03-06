using System;

namespace ClassObject
{
  class Employee
  {
    public string name;

    public void work(string work)
    {
      Console.WriteLine("Work: " + work);
    }
  }

  class EmployeeDrive
  {
    static void Main(string[] args)
    {
      // create Employee object
      Employee e1 = new Employee();

      Console.WriteLine("Employee 1");

      // set name of the Employee
      e1.name = "Gloria";
      Console.WriteLine("Name: " + e1.name);

      //call method of the Employee
      e1.work("Coding");

      Console.ReadKey();
    }
  }
}