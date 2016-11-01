using BankingSystem.Investments;
using System;
using System.Linq;
using System.Text;

namespace BankingSystem
{
    public class TransactionSystem
    {
        private Account _account;

        public TransactionSystem(Account account)
        {
            _account = account;
        }

        public void SendTransfer(double amount)
        {
            // TODO
        }

        public void MakeDeposit(double amount)
        {
            // TODO
        }

        public void TakeNewLoan(double amount)
        {
            // TODO
        }

        public void PayOffLoan(Guid id, double amount)
        {
            // TODO
        } 

        public void InvestMoney(StrategyType type, double amount)
        {
            // TODO
        }

        public string GetAccountInfo()
        {
            var infoBuilder = new StringBuilder()
                .AppendLine("--- Account information ---")
                .AppendLine($"    * Balance: {_account.Balance.ToString("F2")}")
                .AppendLine($"    * Interest rate: {_account.InterestRate.ToString("F2")}");

            if (_account.Loans.Any())
            {
                infoBuilder.AppendLine("    * Loans:");
            }
            foreach (var loan in _account.Loans)
            {
                infoBuilder.AppendLine($"        * id: {loan.Id}, balance: {loan.Balance.ToString("F2")}, rate: {loan.InterestRate.ToString("F2")}");
            }

            if (_account.Investments.Any())
            {
                infoBuilder.AppendLine("    * Investments:");
            }
            foreach (var investment in _account.Investments)
            {
                infoBuilder.AppendLine($"        * name: {investment.Name}, balance: {investment.Balance.ToString("F2")}, volatility: {investment.Volatility.ToString("F2")}");
            }

            return infoBuilder.AppendLine().ToString();
        }
    }
}