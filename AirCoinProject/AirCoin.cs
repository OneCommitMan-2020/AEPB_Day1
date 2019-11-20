using System;

namespace AirCoinProject
{
    public class AirCoin
    {
        private int _amount { get; set; }
        public int Amount
        {
            get => _amount;
            set
            {
                if (value < 0 || value > 2e8)
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