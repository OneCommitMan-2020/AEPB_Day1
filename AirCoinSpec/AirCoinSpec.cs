using System;
using Xunit;
using AirCoinProject;

namespace AirCoinSpec
{
    public class AirCoinSpec
    {

        [Fact]
        public void should_return_an_correct_amount_air_coin_given_a_positive_int_amount()
        {
            var airCoin = new AirCoin(5);
            Assert.Equal(5, airCoin.Amount);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(3e8)]
        public void should_throw_exception_when_create_air_coin_given_incorrect_amount(int amount)
        {
            var exception = Assert.Throws<Exception>(() => new AirCoin(amount));
            Assert.Equal("illegal airCoin amount", exception.Message);
        }

        [Theory]
        [InlineData(1,2,true)]
        [InlineData(1,1,false)]
        public void should_return_true_when_compare_given_two_different_amount_air_coin(int amount1, int amount2, bool result)
        {
            var coin1 = new AirCoin(amount1);
            var coin2 = new AirCoin(amount2);
            Assert.Equal(result, coin1.DifferentWith(coin2));
        }
        
    }
}
