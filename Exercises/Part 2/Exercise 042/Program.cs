using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {
    Console.WriteLine("Input first integer");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input second integer");
    int b = Convert.ToInt32(Console.ReadLine());

    double squareRoot = Math.Sqrt(a+b);
    Console.WriteLine(squareRoot);
    
   
    Console.ReadLine();
    
    }
  }
}
