using System;
using BankingSystem.Investments;

namespace BankingSystem.Subsystems
{
    public class InvestmentsSystem
    {
        private Account _account;

        public InvestmentsSystem(Account account)
        {
            _account = account;
        }

        public void InvestMoney(double amount, StrategyType type)
        {
            _account.ChangeBalance(-amount);
            _account.Investments.Add(InvestmentFactory.CreateInvestment(type, amount));
        }
    }
}
