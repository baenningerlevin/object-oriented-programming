class Car
{
    public string Model;

    public Car()
    {
        Model = "Mustang";
    }

    static void Main(string[] args)
    {
        Car Ford = new Car();
        Console.WriteLine(Ford.Model)
    }
}