using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
    Console.WriteLine ("Speak friend and enter");
    string password = Console.ReadLine();
    string right = "Mellon";
           

    if (String.Equals(password, right))  
        {
                Console.WriteLine("Welcome, friend");
        }        
    else  
        {
          Console.WriteLine("They've got a cave troll!");
         }

    Console.ReadLine();
       
    }
  }
}
