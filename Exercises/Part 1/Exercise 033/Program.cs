using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
    Console.WriteLine ("Give the first string");
    string input1 = Console.ReadLine();

    Console.WriteLine ("Give the second string");
    string input2 = Console.ReadLine();
    
           

    if (String.Equals(input1, input2))  
        {
                Console.WriteLine("Echo");
        }        
    else  
        {
          Console.WriteLine("Nope");
         }

    Console.ReadLine();

    }
  }
}
