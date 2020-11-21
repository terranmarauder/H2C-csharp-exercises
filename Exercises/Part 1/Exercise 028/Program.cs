using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
     Console.WriteLine("How old are you");
     string userInput = Console.ReadLine();
     int intValue = Convert.ToInt32(userInput);

    if (intValue < 18) 
        {
            Console.WriteLine("You're underage");
        }

    if (intValue > 18) 
        {
            Console.WriteLine("You're an adult");
        }

      Console.ReadLine();
    }
  }
}
