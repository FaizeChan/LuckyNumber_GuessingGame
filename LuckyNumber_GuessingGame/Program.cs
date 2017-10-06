using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumber_GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("\n");
            Console.WriteLine("Hello, and Welcome to Faizon's Marvelous Cash Making Casino Playing \nAward Winning Extravaganza!");
            Console.WriteLine("I'll be your Host Faizon, and we are going to play a Number Guessing game");
            Console.WriteLine("\n");
            Console.WriteLine("Are you ready to play? (Yes or No)");
            string userAnswer = Console.ReadLine().ToLower().Trim();
            string Agree = "yes";
            string Disagree = "no";
            Console.WriteLine();
            if (userAnswer == Agree)
            {
                Console.WriteLine("Alright, Lets Begin. What is the starting number for the lowest number in the \nnumber range?");
                int startingNumber = int.Parse(Console.ReadLine());
            }
            else if (userAnswer == Disagree)
            {
                Console.WriteLine("Tsk tsk.. Not even going to try? Well maybe next time.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("That's not one of the options, so I will take that as a no. Maybe next time.");
                Environment.Exit(0);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Alright, what is the ending number of the highest number in the number range?");
            int endingNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("Cool. Now guess (6) numbers you think will be the lucky numbers \ngenerated within the number range.");

                int[] index = new int[6];
                for (int i = 0; i < index.Length; i++)
                {
                    index[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Good, guess another number.");
                }
                
                Console.WriteLine("\n");
                Random luckyNumbers = new Random();
                for (int luckyNumber = 1; luckyNumber <= 6; luckyNumber++)
           {
                int guessedNumber = luckyNumbers.Next(endingNumber) + 1;
                Console.Write("\nLucky Number ");
                Console.WriteLine("{0}", guessedNumber);

                if (guessedNumber > endingNumber)
                {
                    Console.WriteLine("Please give a valid number.");
                }
            }

                       
        }
    }
}
