using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {
    int counter = -1;
    Console.WriteLine("Input an integer");
    int number = Convert.ToInt32(Console.ReadLine());
            
    while (true) 
    {
    
    

    if (counter == number) 
        {
            break;
        }
    counter++;    
    Console.WriteLine(counter);
    }
    
    Console.ReadLine();

    }
  }
}
