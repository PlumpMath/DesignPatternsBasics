using BankingSystem.Investments;

namespace BankingSystem.Subsystems
{
    public class InvestmentsSystem : NotifierBase, INotifier
    {
        private Account _account;

        public InvestmentsSystem(Account account)
        {
            _account = account;
        }

        public void InvestMoney(double amount, StrategyType type)
        {
            var investment = InvestmentFactory.CreateInvestment(type, amount);
            _account.Investments.Add(investment);
            _account.ChangeBalance(-amount);
            Notify($"Investment has been made. Amount: {amount.ToString("F2")}, name: {investment.Name}");
        }
    }
}
