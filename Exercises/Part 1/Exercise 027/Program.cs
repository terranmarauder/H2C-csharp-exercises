using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
     Console.WriteLine("Give a number");
     string userInput = Console.ReadLine();
     int intValue = Convert.ToInt32(userInput);

    if (intValue > 0) 
        {
            Console.WriteLine("It is positive");
        }

    if (intValue < 0) 
        {
            Console.WriteLine("It is not positive");
        }

      Console.ReadLine();

    }
  }
}
