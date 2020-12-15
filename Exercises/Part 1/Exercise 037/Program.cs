using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
    int counter = 0;

    while (true) 
    {
        Console.WriteLine("Input an integer, 0 quits");
        int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0) 
            {
                break;
            }
        
        counter++;
    }
    
    Console.WriteLine("Total amount of numbers: " + (counter));
    Console.ReadLine();
    }
  }
}
