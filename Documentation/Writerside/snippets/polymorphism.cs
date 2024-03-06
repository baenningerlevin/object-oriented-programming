class Animal
{
  public virtual void animalSound()
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal
{
  public override void animalSound()
  {
    Console.WriteLine("The pig says: oink oink");
  }
}

class Dog : Animal
{
  public override void animalSound()
  {
    Console.WriteLine("The dog says: woof woof");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Animal myAnimal = new Animal();
    Animal myPig = new Pig();
    Animal myDog = new Dog();

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}