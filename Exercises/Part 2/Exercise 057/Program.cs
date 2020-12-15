using System;

namespace exercise_57
{
class Program
    {
    public static int Sum(int a, int b, int c, int d)
        {
            int answer = a + b + c + d;
            return answer;
            
        }
        public static void Main(string[] args)
        {
            int answer = Sum(1, 2, 3, 4);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
  }
}