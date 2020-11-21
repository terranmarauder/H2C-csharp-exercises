using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

     Console.WriteLine("Your speed");
     string userInput = Console.ReadLine();
     int intValue = Convert.ToInt32(userInput);

    if (intValue > 120) 
        {
            Console.WriteLine("Speeding!");
        }

      Console.ReadLine();

    }

  }
}
