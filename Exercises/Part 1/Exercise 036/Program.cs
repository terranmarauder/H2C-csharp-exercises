﻿using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true) 
    {
        Console.WriteLine("Give a number");
        int number = Convert.ToInt32(Console.ReadLine());
      if (number == 0) 
        {
            break;
        }
      if  (number < 0)
        {
            Console.WriteLine("That is negative");
            continue;
        }

      if  (number > 0)
        {
            Console.WriteLine(number * number);
            continue;
        }
         
}


    }
  }
}
