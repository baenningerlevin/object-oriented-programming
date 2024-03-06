class Animal
{
    public virtual void eat()
    {
      Console.WriteLine("Animals eat food.");
    }
}

class Dog : Animal
{
    public override void eat()
    {
      base.eat();
      Console.WriteLine("Dogs eat Dog food.");
    }
  }

class Program
{
    static void Main(string[] args)
    {
      Dog labrador = new Dog();
      labrador.eat();
    }
  }
}