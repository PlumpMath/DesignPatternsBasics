using System;

namespace BankingSystem.Investments
{
    public enum StrategyType
    {
        HighRisk,
        MediumRisk,
        LowRisk
    }

    public class InvestmentFactory
    {
        public static Investment CreateInvestment(StrategyType type, double initialBalance)
        {
            switch (type)
            {
                case StrategyType.HighRisk:
                    return new HighRiskInvestment(initialBalance);
                case StrategyType.MediumRisk:
                    return new MediumRiskInvestment(initialBalance);
                case StrategyType.LowRisk:
                    return new LowRiskInvestment(initialBalance);
                default:
                    throw new Exception("Unknown strategy type.");
            }
        }
    }
}