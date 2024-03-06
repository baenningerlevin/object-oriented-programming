namespace foreachLoop
{
  internal class Program
  {
    static void Main(string[] args)
    {
      char[] genders = ['m', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f'];
      int male = 0, female = 0;

      foreach (char gender in genders)
      {
        if (gender == 'm')
          male++;
        else if (gender == 'f')
          female++;
      }

      Console.WriteLine("Number of male: {0}", male);
      Console.WriteLine("Number of female: {0}", female);

      Console.ReadKey();
    }
  }
}
