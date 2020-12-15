using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
    Console.WriteLine("Input from");
    int min = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input to");
    int max = Convert.ToInt32(Console.ReadLine());  
            
    // call method    
    DivisibleByThreeInRange(min, max);
    Console.ReadLine();
    }

    // my method
    public static void DivisibleByThreeInRange(int min, int max) 
    {

    while (true)
    {
       if (min > max) 
            {
             break;
            } 

       

       if ((min % 3) == 0) 
        {
            Console.WriteLine(min);
        }

       min++; 
    }            
                      
    }
  }
}

