using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
    Console.WriteLine("Input an integer");
    int value = Convert.ToInt32(Console.ReadLine());
    
    if (value < 0) 
    {
        Console.WriteLine(value*-1);
    } 
    else 
    {
        Console.WriteLine(value);
    }
      
    Console.ReadLine();


    }
  }
}
