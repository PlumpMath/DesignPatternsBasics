using BankingSystem.Investments;

namespace BankingSystem
{
    class AccountBuilder
    {
        private readonly Account _account;

        public AccountBuilder()
        {
            _account = Account.GetEmptyAccount();
        }

        public AccountBuilder AddInitialBalance(double initialBalance)
        {
            _account.AddToBalance(initialBalance);
            return this;
        }

        public AccountBuilder AddLoan(double amount)
        {
            _account.Loans.Add(Loan.Create(amount));
            return this;
        }

        public AccountBuilder AddInvestment(double amount, StrategyType type)
        {
            var investment = InvestmentFactory.CreateInvestment(type, amount);
            _account.Investments.Add(investment);
            return this;
        }

        public Account Setup()
        {
            return _account;
        }
    }
}
