using System;

namespace BankingSystem.Investments
{
    public abstract class Investment : IBankingProduct
    {
        protected static Random _random = new Random();

        public Investment(double initialBalance)
        {
            Balance = initialBalance;
        }

        public double Balance { get; private set; }

        public abstract string Name { get; }

        public abstract double Volatility { get; }

        public void Evaluate()
        {
            var u = _random.NextDouble();
            var move = u * Volatility - Volatility / 2;
            Balance *= 1 + move;
        }
    }
}