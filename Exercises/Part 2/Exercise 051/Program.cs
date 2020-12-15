using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
    Console.WriteLine("Up to which number");
    string userInput = Console.ReadLine();
    int intValue = Convert.ToInt32(userInput);
    PrintUntilNumber(intValue);
    Console.ReadLine();
    }

    public static void PrintUntilNumber(int numOfTimes) 
    {
    int i = 1;
    while (i <= numOfTimes) 
    {
        Console.WriteLine(i);
        i++;
    }


    }

  }
}
