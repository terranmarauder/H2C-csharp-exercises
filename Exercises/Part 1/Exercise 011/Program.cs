using System;

namespace exercise_11
{
    class Program
    {
        public static void Main(string[] args)
        {
            int dayCount = 100; // I could have just changed the value from 100 to 200 here. Same for the hours and statement
            dayCount =200;
            double hoursToLunch = 1;
            hoursToLunch = 3.5;
            string statement = "Are you sure?";
            statement = "It sure is!";

            // DO NOT TOUCH THESE!
            Console.WriteLine("Days to summer:");
            Console.WriteLine(dayCount);
            Console.WriteLine("Hours to lunch:");
            Console.WriteLine(hoursToLunch);
            Console.WriteLine("Coding is fun:");
            Console.WriteLine(statement);


            Console.ReadLine();
        }
    }
}
