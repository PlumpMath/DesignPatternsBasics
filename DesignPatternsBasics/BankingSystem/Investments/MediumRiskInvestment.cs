namespace BankingSystem.Investments
{
    public class MediumRiskInvestment : Investment
    {
        public MediumRiskInvestment(double initialBalance) : base(initialBalance)
        { }

        public override string Name { get; } = "Medium Risk Investment";

        public override double Volatility { get; } = 0.15;
    }
}