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
                .AddNotifications()
                .Setup();

            WriteLine(account);
            account.SendTransfer(450);
            account.InvestMoney(3000, StrategyType.MediumRisk);
            WriteLine(account);
            account.Evaluate();
            WriteLine(account);

            ReadKey();
        }
    }
}
