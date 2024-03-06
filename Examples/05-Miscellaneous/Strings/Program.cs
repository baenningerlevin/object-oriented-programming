namespace Strings
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Length
      string firstName = "John";
      Console.WriteLine($"{firstName} has {firstName.Length} characters");

      // Concat()
      string lastName = "Doe";
      string fullName = string.Concat(firstName, lastName);
      Console.WriteLine(fullName);

      // Equals()
      string name = "John";
      string name2 = "John";
      string name3 = "Kevin";

      Console.WriteLine(name.Equals(name2)); // True
      Console.WriteLine(name.Equals(name3)); // False

      // ToUpper() / ToLower()
      string str = "C# Programming";
      Console.WriteLine(str.ToUpper());
      Console.WriteLine(str.ToLower());

      // IndexOf()
      string str2 = "Please locate where 'locate' occurs!";
      Console.WriteLine(str2.IndexOf("locate")); // 7

      // Substring()
      string str3 = "C# Programming";
      Console.WriteLine(str3.Substring(2)); // Programming
      Console.WriteLine(str3.Substring(2, 5)); // Progr

      // Trim()
      string str4 = "   C# Programming   ";
      Console.WriteLine(str4.Trim()); // C# Programming

      // Replace()
      string str5 = "C# Programming";
      Console.WriteLine(str5.Replace("C#", "Java")); // Java Programming

      // Escape characters
      string str6 = "\tWe are the so-called \"Vikings\" from the north.\n";
      Console.WriteLine(str6);

      Console.ReadKey();
    }
  }
}
