using System;

namespace CoinChangeProblem
{
    /// <summary>
    /// Main class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        static void Main()
        {
            // Title

            Console.WriteLine("Coin Change Problem");
            Console.WriteLine();

            // Initialize the variables

            int money = 10;
            int[] coins = { 2, 5, 3, 6 };

            // Output the variables

            Console.WriteLine("Amount of money: {0}", money);
            Console.Write("Coins available: ");

            // Print the coins

            for (int i = 0; i < coins.Length; i++)
            {
                if (i == coins.Length)
                {
                    Console.Write(coins[i]);
                }
                else
                {
                    Console.Write(coins[i] + ", ");
                }
            }

            // Calculate the changes

            int result = CountChange.CountChangePossibilities(money, coins);

            // Output result

            Console.WriteLine();
            Console.WriteLine("Number of possible changes: {0}", result);
            Console.ReadKey();
        }
    }
}
