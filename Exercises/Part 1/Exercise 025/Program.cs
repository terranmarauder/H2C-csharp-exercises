using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
       Console.WriteLine("Input integer");
     string userInput = Console.ReadLine();
     int intValue = Convert.ToInt32(userInput);

    if (intValue == 1984) 
        {
            Console.WriteLine("Orwell");
        }

      Console.ReadLine();

    }
  }
}
