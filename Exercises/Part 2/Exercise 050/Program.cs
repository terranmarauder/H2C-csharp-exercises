﻿using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
           
    {
    int i = 0;
    Console.WriteLine("How many times?");
    int numOfTimes = Convert.ToInt32(Console.ReadLine());

    while (true)
    {   
        PrintPhrase();
        i++;
                
    if (i == numOfTimes) 
    {
        break;
    }  
    
    }

    Console.ReadLine(); 
    
    }
   
    public static void PrintPhrase() 
    {      
        {
                Console.WriteLine("In a hole in the ground there lived a method");    
        }
    }
        
  }
    
}
