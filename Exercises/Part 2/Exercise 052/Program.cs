using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
    Console.WriteLine("Input number");
    string userInput = Console.ReadLine();
    int intValue = Convert.ToInt32(userInput);
    Console.WriteLine("");

    PrintFromNumberToOne(intValue);
    Console.ReadLine();
    }

    public static void PrintFromNumberToOne(int numOfTimes) 
    {
    int i = 0;
    while (i < numOfTimes) 
    {
        Console.WriteLine((numOfTimes - i));
        i++;
    }


    }
  }
}
