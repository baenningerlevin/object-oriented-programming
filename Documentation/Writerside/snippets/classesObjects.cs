using System;

namespace ClassesObjects
{
  class Dog
  {
    string breed;

    public void Bark()
    {
      Console.WriteLine("Woof, Woof!");
    }

    static void Main(string[] args)
    {
      // create Dog object
      Dog bullDog = new Dog();

      // access breed of the Dog
      bullDog.breed = "Bull Dog";
      Console.WriteLine(bullDog.breed);

      // access method of the Dog
      bullDog.Bark();


      Console.ReadKey();
    }
  }
}