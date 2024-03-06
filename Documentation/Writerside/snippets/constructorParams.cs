class Car
{
  public string Model;
  public string Color;
  public int Year;

  // Create a class constructor with multiple parameters
  public Car(string modelName, string modelColor, int modelYear)
  {
    Model = modelName;
    Color = modelColor;
    Year = modelYear;
  }

  static void Main(string[] args)
  {
    Car Ford = new Car("Mustang", "Red", 1969);
    Console.WriteLine($"{Ford.Color} {Ford.Year} {Ford.Year}");
  }
}