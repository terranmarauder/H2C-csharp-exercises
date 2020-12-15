using System;

namespace exercise_59
{
  class Program
  {
   public static int GrEatest(int a, int b, int c) 
    {
      // write your code here
      // do not print anything inside the method

     if (a > b)
        {
            if (a > c)
            {
              int answer = a;
              return answer;  
            }
            else
            {
              int answer = c;
              return answer;  
            }
        }

            else if (b > c)
            {
                int answer = b;
                return answer; 
            }
            else 
            {
            int answer = c;
            return answer;  
            }
    }

    public static void Main(string[] args) 
    {
      int answer =  GrEatest(2, 7, 3);
      Console.WriteLine("GrEatest: " + answer);
      Console.ReadLine();
    }    
  }
}








