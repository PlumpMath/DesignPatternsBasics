namespace BankingSystem.Investments
{
    public class HighRiskInvestment : Investment
    {
        public HighRiskInvestment(double initialBalance) : base(initialBalance)
        {
        }

        public override string Name { get; } = "High Risk Investment";

        public override double Volatility { get; } = 0.25;
    }
}