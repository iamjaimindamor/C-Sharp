using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int secretnum = random.Next(0, 20);
            int GuessedNum;
            int i = 0;

            do
            {

                Console.Write("Guess The Number : ");
                GuessedNum = Convert.ToInt32(Console.ReadLine());
                i++;

                if (GuessedNum < secretnum)
                {
                    Console.WriteLine("The Value Is Bigger Then That,Try Again");
                }
                else if (GuessedNum > secretnum)
                {
                    Console.WriteLine("The Value is smaller then that , Try Again ");
                }
                else

                {
                    Console.WriteLine("Correct Vamos Amigos");
                }

                      
                               

            } while (secretnum != GuessedNum);

            Console.WriteLine("Alas, You Guessed it Correctly After {0} Attempts The Answer indeed is {1} ", i, secretnum);

            Console.ReadLine();


        }
    }
}
