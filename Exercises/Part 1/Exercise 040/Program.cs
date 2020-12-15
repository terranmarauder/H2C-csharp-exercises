using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

    int counter = 0;
    int sum = 0;
    while (true) 
    {
        Console.WriteLine("Input an integer, 0 quits");
        int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0) 
            {
                break;
            }
               
        sum = sum + number; 
        counter++;            
    }
    
    Console.WriteLine("Total sum of numbers: " + (sum)+ "\n Total amount of numbers " + (counter));
    Console.ReadLine();
    }
  }
}
