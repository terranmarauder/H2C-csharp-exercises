using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

        Console.WriteLine("Give a string");
        string userString= Console.ReadLine();
        
        
        Console.WriteLine("Give an integer");
        string userInt= Console.ReadLine();

        Console.Write("Give double value: "); 
        double userDouble = Convert.ToDouble(Console.ReadLine());
       
        Console.WriteLine("Give me the truth!");
        string truth = Console.ReadLine();
        bool booleanValue = System.Convert.ToBoolean(truth);

        Console.WriteLine("Your string: " + userString);    
        Console.WriteLine("Your integer: " + userInt);
        Console.WriteLine("Your double: " + userDouble);
        Console.WriteLine("Your boolean: " + booleanValue); 

        Console.ReadLine();

    }
  }
}
