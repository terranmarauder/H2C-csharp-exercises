using System;

namespace exercise_23
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
     
     double divide = Convert.ToDouble(intValue);
     double divide2 = Convert.ToDouble(intValue2);      

     Console.WriteLine(userInput + " + " + userInput2 + " = " + (intValue + intValue2));
     Console.WriteLine(userInput + " - " + userInput2 + " = " + (intValue - intValue2));
     Console.WriteLine(userInput + " * " + userInput2 + " = " + (intValue * intValue2));
     Console.WriteLine(userInput + " / " + userInput2 + " = " + (divide / divide2));
          
     Console.ReadLine();

    }
  }
}
