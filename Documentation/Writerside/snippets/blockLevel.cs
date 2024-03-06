using System;

namespace VariableScope
{
  class Program
  {
    public void display()
    {
      for(int i=0;i<=3;i++) {

      }
    Console.WriteLine(i);
    }

    static void Main(string[] args) {
      Program ps = new Program();
      ps.display();

      Console.ReadKey();
    }
  }
}