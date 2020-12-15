using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

    Console.WriteLine("Input first integer");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input first integer");
    int b= Convert.ToInt32(Console.ReadLine());

   
    
    if (a > b) 
    {
        Console.WriteLine(a + " is greater than " +b);
    } 
    else if (a < b)
    {
        Console.WriteLine(a + " is less than than " +b);
    }
    
    else
    {
        Console.WriteLine(a + " is equal to " +b);
    }

    Console.ReadLine();
    }
  }
}
