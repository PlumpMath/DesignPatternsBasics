namespace BankingSystem.Investments
{
    public abstract class Investment
    {
        public Investment(double initialBalance)
        {
            Balance = initialBalance;
        }

        public double Balance { get; private set; }

        public abstract string Name { get; }

        public abstract double Volatility { get; }
    }
}