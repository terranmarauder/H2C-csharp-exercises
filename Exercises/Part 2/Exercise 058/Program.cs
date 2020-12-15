using System;

namespace exercise_58
{
  class Program
  {
   public static int Smallest(int a, int b) 
    {
      // write your code here
      // do not print anything inside the method

      if (a<b)
      {
        int answer = a;
        return answer;  
      }
      
      else 
      {
        int answer = b;
        return answer; 
      }      
    }

    public static void Main(string[] args) 
    {
      int answer =  Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
      Console.ReadLine();
    }    
  }
}
