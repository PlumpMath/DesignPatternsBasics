namespace BankingSystem.Investments
{
    public class LowRiskInvestment : Investment
    {
        public LowRiskInvestment(double initialBalace) : base(initialBalace)
        { }

        public override string Name { get; } = "Low Risk Investment";

        public override double Volatility { get; } = 0.05;
    }
}