using System;

namespace ClassObject
{
  class Employee
  {
    string department;

    static void Main(string[] args)
    {
      // create Employee object
      Employee sheeran = new Employee();

      // set department for sheeran
      sheeran.department = "Development";
      Console.WriteLine("Sheeran: " + sheeran.department);

      // create second object of Employee
      Employee taylor = new Employee();

      // set department for taylor
      taylor.department = "Content Writing";
      Console.WriteLine("Taylor: " + taylor.department);

      Console.ReadKey();
    }
  }
}