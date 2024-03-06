using System.Xml.Serialization;

namespace Methods
{
    class Program
    {
        // Create a method without parameters and return type
        static void SayHi()
        {
            Console.WriteLine("Hi!");
        }

        // Create a method with parameters and return type
        static int Add(int x, int y)
        {
            return x + y;
        }

        // Default parameters
        static int Subtract(int x = 0, int y = 0)
        {
            return x - y;
        }

        // Named arguments
        static void Print(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }

        // Method overloading
        static void Print(string firstName)
        {
            Console.WriteLine(firstName);
        }

        static void Print(string firstName, string lastName, string middleName)
        {
            Console.WriteLine($"{firstName} {middleName} {lastName}");
        }

        static void Main(string[] args)
        {
            // Call methods
            SayHi();
            Console.WriteLine(Add(5, 7));
            Console.WriteLine(Subtract(5));
            Print(lastName: "Doe", firstName: "John");
            Print("John");
            Print("John", "Doe", "Smith");

            Console.ReadKey();
        }
    }
}
