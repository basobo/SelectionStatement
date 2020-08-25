using System;

namespace SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //int favoriteNumber = 7;
            //Console.WriteLine("Guess the favorite number hint: below =10");
            //int userGuess = int.Parse(Console.ReadLine());

            //if (userGuess < favoriteNumber)
            //{
            //Console.WriteLine("Too low !!!");
            //}

            //else if(userGuess>favoriteNumber)
            //{
            //Console.WriteLine("Too High!!!");
            //}
            //else if (userGuess==favoriteNumber)
            //{
            // Console.WriteLine("You were correct here is a cookie");

            //}
            //else 
            //{
            //Console.WriteLine("never mind");

            //}

            string subject = "c#";
            Console.WriteLine("choose a subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "c#":
                    Console.WriteLine("You are in the right class");
                    break;
                case "java":
                    Console.WriteLine("c# is better than java");
                    break;
                default:
                    break;
            }

        }
    }
}
