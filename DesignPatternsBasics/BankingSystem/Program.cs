using BankingSystem.Investments;
using static System.Console;

namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new AccountBuilder()
                .AddInitialBalance(10000)
                .AddIntrestRate(0.03)
                .AddLoan(3000, LoanType.Car)
                .AddInvestment(2000, StrategyType.HighRisk)
                .AddInvestment(5000, StrategyType.LowRisk)
                .Setup();

            var transactionSystem = account.GetTransactionSystem();
            for (int i = 0; i < 10; i++)
            {
                WriteLine(transactionSystem.GetAccountInfo());
                account.Evaluate();
            }

            ReadKey();
        }
    }
}
