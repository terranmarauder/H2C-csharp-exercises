using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {    
    Console.WriteLine("Where to");
    int numberTo = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Where from");
    int numberFrom = Convert.ToInt32(Console.ReadLine());
    int counter = numberFrom;        
    while (true) 
    {
    
    if (counter == numberTo) 
        {
            break;
        }
    if (numberFrom >= numberTo) 
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
