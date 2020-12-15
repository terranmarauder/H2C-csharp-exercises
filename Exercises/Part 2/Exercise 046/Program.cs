using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.WriteLine("Input an integer");
    int number = Convert.ToInt32(Console.ReadLine());
    int counter = (number-1);        
    while (true) 
    {
    if (counter == 100) 
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
