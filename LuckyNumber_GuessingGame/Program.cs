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
            //Simple ask the smallest below above | and give the smallest integer 

            Console.WriteLine("Alright, Lets Begin. What is the starting number for the lowest number in the \nnumber range?");
            int startingNumber = int.Parse(Console.ReadLine());

            //Ask the largest number below | and give largest integer

            Console.WriteLine("\n");
            Console.WriteLine("Alright, what is the ending number of the highest number in the number range?");
            int endingNumber = int.Parse(Console.ReadLine());

            //Now here comes the first Array and loop with an if statement.

            Console.WriteLine("\n");
            Console.WriteLine("Cool. Now guess (6) numbers you think will be the lucky numbers \ngenerated within the number range.");
            int[] usrGuess = new int[6];
            for (int i = 0; i < usrGuess.Length; i++)
            {
                usrGuess[i] = int.Parse(Console.ReadLine());
                {
                    if (usrGuess[i] < startingNumber || usrGuess[i] > endingNumber)
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                }
                }




             
        }
    }
}
