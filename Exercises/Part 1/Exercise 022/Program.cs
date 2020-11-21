using System;

namespace exercise_22
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

     Console.WriteLine("Give the second number!");
     string userInput3 = Console.ReadLine();
     int intValue3 = Convert.ToInt32(userInput3);

     //double average = (intValue + intValue2 + intValue3) / 3.0;  

     Console.WriteLine("The average is: {0:0.0}",(intValue + intValue2 + intValue3)/3.0); 
           
          
     Console.ReadLine();

    }
  }
}
