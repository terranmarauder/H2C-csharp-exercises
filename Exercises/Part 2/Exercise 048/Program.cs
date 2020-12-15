using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
    int sum = 0;
    int counter = 0;
    int counterOdd = 0;

    while (true) 
    {
    
    Console.WriteLine("Give numbers");
    int userInput = Convert.ToInt32(Console.ReadLine());

    if (userInput == -1) 
        {
            Console.WriteLine("Thx Bye!");
            break;
        }
    
   
    if ((userInput %2) != 0) 
        {
            counterOdd++;
        }
     
    sum=sum+userInput;
    counter++;
    }

    Console.WriteLine("Sum: " + sum);
    Console.WriteLine("Numbers: " + counter);
    double sumDouble = Convert.ToDouble(sum);
    Console.WriteLine("Average: " + (sumDouble/counter));
    Console.WriteLine("Even: " + (counter-counterOdd));
    Console.WriteLine("Odd: " + counterOdd);

    Console.ReadLine();  
    }
        
  }
}
