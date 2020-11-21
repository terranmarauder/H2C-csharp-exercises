using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
     Console.WriteLine("Give the first number");
     string userInput1 = Console.ReadLine();
     int intValue1 = Convert.ToInt32(userInput1);

     Console.WriteLine("Give the second number");
     string userInput2 = Console.ReadLine();
     int intValue2 = Convert.ToInt32(userInput2);

     if (intValue1 > intValue2)
        {
            Console.WriteLine("The larger number is " + intValue1);
        }
    
     else if  (intValue1 < intValue2)
    {
        Console.WriteLine("The larger number is " + intValue2);
    }

     else if  (intValue1 == intValue2)
    {
        Console.WriteLine("They are equal");
    }
     
     Console.ReadLine();

    }
  }
}
