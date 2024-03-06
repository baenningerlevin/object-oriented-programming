namespace Constructor
{
    class Car
    {
        public string Model { get; set; }

        // Constructor
        public Car(string model)
        {
            Model = model;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Mustang");
            Console.WriteLine(myCar.Model);

            Console.ReadKey();
        }
    }
}
