using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
    int counter = 0;
    int negcounter = 0;
    while (true) 
    {
        Console.WriteLine("Input an integer, 0 quits");
        int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0) 
            {
                break;
            }
        
        counter++;

            if (number < 0)
            {
                negcounter++;
            }
    }
    
    Console.WriteLine("Total amount of negative numbers: " + (negcounter));
 
    Console.ReadLine();

    }
  }
}
