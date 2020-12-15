using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {
    Console.WriteLine("Give the first number!");
    string userInput = Console.ReadLine();
    int intValue = Convert.ToInt32(userInput);
     
    Console.WriteLine("Give the second number!");
    string userInput2 = Console.ReadLine();
    int intValue2 = Convert.ToInt32(userInput2); 

    Console.WriteLine("The average is: {0:0.0}",(intValue + intValue2)/2.0); 
           
          
    Console.ReadLine();

    }
  }
}
