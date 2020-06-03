using System;
using System.Collections.Generic;
using System.Text;

namespace CoinChangeProblem
{
    public class CountChange
    {
        #region Public Methods

        /// <summary>
        /// Counts the change.
        /// </summary>
        /// <param name="money">The money.</param>
        /// <param name="coins">The coins.</param>
        /// <returns>The change.</returns>
        public static int CountChangePossibilities(int money, int[] coins)
        {
            int[] count = new int[money + 1];
            count[0] = 1;

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = coins[i]; j <= money; j++)
                {
                    count[j] += count[j - coins[i]];
                }
            }

            return count[money];
        }

        #endregion
    }
}
