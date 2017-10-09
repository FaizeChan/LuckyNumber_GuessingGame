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



            string playAgain = "";

            do
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
                        while (usrGuess[i] < startingNumber || usrGuess[i] > endingNumber)
                        {
                            Console.WriteLine("Please enter a valid number.");
                            usrGuess[i] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                

                    //Going to have the computer radomize and pick a number between the starting and ending number.

                    int[] pcNumber = new int[6];
                    Random rand = new Random();
                    for (int j = 0; j < pcNumber.Length; j++)
                    {
                        int randomNumber = rand.Next(startingNumber, endingNumber) + 1;
                        pcNumber[j] = randomNumber;
                        Console.WriteLine("Lucky Number: " + pcNumber[j]);
                    }
                // Just hardcoding the reward for part 3 here.
                int Jackpot = 250000;
                for (int i = 0; i < 6; i++)
                {
                    if (usrGuess.Contains(pcNumber[i]))
                    {
                        Console.WriteLine("You win the Jackpot! You get $" + Jackpot);
                        break;                       
                    }
                    else if(usrGuess.Contains(pcNumber[i] -1))
                    {
                        Console.WriteLine("You got 5 out of 6 correct, You get" );
                    }
                }







                        Console.WriteLine("Do you want to play again? (Yes/No)");
                playAgain = Console.ReadLine().ToLower();
            } while (playAgain == "yes");
        }
    }
}
