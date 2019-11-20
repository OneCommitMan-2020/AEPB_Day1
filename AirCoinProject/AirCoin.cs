using System;

namespace AirCoinProject
{
    public class AirCoin
    {
        private const int MaxValue =  (int) 2e8;
        private const int MinValue =  0;
        private int _amount { get; set; }
        public int Amount
        {
            get => _amount;
            set
            {
                if (value < MinValue || value > MaxValue)
                {
                    throw new Exception("illegal airCoin amount");
                }
                _amount = value;
            }
        }

        public AirCoin(int amount)
        {
            Amount = amount;
        }

        public bool DifferentWith(AirCoin coin)
        {
            return !_amount.Equals(coin.Amount);
        }
    }
}
