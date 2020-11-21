using System;

namespace exercise_13
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Give double value: "); 
            // note: inputting using a (UK) decimal point in  Finnish region throws an error. The solution can be used to check and convert it but it's beyond the scope of this simple exercise.  
            double userInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You gave: " + userInput); 
            Console.ReadLine();
        }
        
    }
}

