using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
    Console.WriteLine("Input numerator");
    double numerator = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Input denominator");
    double denominator = Convert.ToDouble(Console.ReadLine());
    
    
    Division(numerator, denominator);
    Console.ReadLine();
    }

    public static void Division(double numerator,double denominator) 
    {
        Console.WriteLine(numerator/denominator);
           
    }
  }
}
