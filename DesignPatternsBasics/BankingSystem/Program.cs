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
                .AddLoan(3000)
                .AddInvestment(2000, StrategyType.HighRisk)
                .AddInvestment(5000, StrategyType.LowRisk)
                .Setup();

            WriteLine($"Balance: {account.Balance}");
            WriteLine($"Number of loans: {account.Loans.Count}");
            foreach (var loan in account.Loans)
            {
                WriteLine($"Loan ID: {loan.Id}, balance: {loan.Balance}");
            }
            WriteLine($"Number of investment: {account.Investments.Count}");
            foreach (var investment in account.Investments)
            {
                WriteLine($"Investment name: {investment.Name}, balance: {investment.Balance}, volatility: {investment.Volatility}");
            }

            ReadKey();
        }
    }
}
