﻿using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("How many days?");
      string userInput = Console.ReadLine();
      int intValue = Convert.ToInt32(userInput);
      Console.WriteLine("You gave " + intValue);
      Console.WriteLine(intValue * 86400); 

      Console.ReadLine();
    }
  }
}
