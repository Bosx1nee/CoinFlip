using System;

namespace coinflip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            Random rng = new Random();

            Console.Write("Enter Guess Heads ot Tails (H or T)");
            userGuess = Console.ReadLine();

            coin = rng.Next(0, 2);

            if(coin == 0 && userGuess == "T")
            {
                Console.WriteLine("The coin was Tails, you win!");
            }
            else if (coin == 1 && userGuess == "H")
            {
                if (coin == 0)
                {
                    Console.WriteLine("The coin was Tails, you lose");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
