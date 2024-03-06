namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion
            byte a = 1;
            int i = a;
            Console.WriteLine(i);

            // Explicit conversion
            int j = 1;
            byte b = (byte) j;
            Console.WriteLine(b);

            // Non-compatible types
            string number = "1234";
            int k = Convert.ToInt32(number);
            Console.WriteLine(k);
        }
    }
}
