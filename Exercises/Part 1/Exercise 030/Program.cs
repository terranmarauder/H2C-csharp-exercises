using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
     Console.WriteLine("Give your percentage");
     string userInput = Console.ReadLine();
     int intValue = Convert.ToInt32(userInput);

    if (intValue < 0)
        {
            Console.WriteLine("Impossible");
        }
    
    else if (intValue <=49)
        {
            Console.WriteLine("Fail");
        }
    
    else if (intValue <=59)
        {
            Console.WriteLine("Grade: 1");
        }

    else if (intValue <=69)
        {
            Console.WriteLine("Grade: 2");
        }
    else if (intValue <=79)
        {
            Console.WriteLine("Grade: 3");
        }
    else if (intValue <=89)
        {
            Console.WriteLine("Grade: 4");
        }
    
    else if (intValue <=100)
        {
            Console.WriteLine("Grade: 5");
        }

    else if (intValue >100)
        {
            Console.WriteLine("Outstanding!");
        }
             
            
    Console.ReadLine();

    }
  }
}
