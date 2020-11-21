using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.\n" +
            "Give me a name for the main character");
            string name = Console.ReadLine();            
            Console.WriteLine("Give me a destination for the character");
            string destination = Console.ReadLine();
            Console.WriteLine("And so begins our story\n" +
                "Once upon a time there was a Hobbit called " + name +
                "\n" + 
                "who was tasked with taking a ring to " + 
                destination +
                ".\n" +
                "Once there, they had to destroy the ring.");
            Console.ReadLine();

        }
    }
}
