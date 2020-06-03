using System;
using CoinChangeProblem;
using Xunit;

namespace CoinChnageProblemUnitTests
{
    public class UnitTests
    {
        #region Tests

        /// <summary>
        /// Count the change possibilities should return 3.
        /// </summary>
        [Fact]
        public void CountChangePossibilitiesShouldReturn3()
        {
            int money = 4;
            int[] coins = { 1, 2 };

            Assert.Equal(3 , CountChange.CountChangePossibilities(money, coins));
        }

        /// <summary>
        /// Count the change possibilities should return 5.
        /// </summary>
        [Fact]
        public void CountChangePossibilitiesShouldReturn4()
        {
            int money = 10;
            int[] coins = { 5, 3, 2 };

            Assert.Equal(4, CountChange.CountChangePossibilities(money, coins));
        }

        #endregion
    }
}
