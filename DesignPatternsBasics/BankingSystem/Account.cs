using BankingSystem.Investments;
using System.Collections.Generic;
using BankingSystem.Subsystems;
using System;
using System.Text;
using System.Linq;

namespace BankingSystem
{
    public class Account : IBankingProduct, ITransactionSystem
    {
        private readonly TransfersSystem _transfersSystem;
        private readonly LoansSystem _loansSystem;
        private readonly InvestmentsSystem _investmentsSystem;
        private NotificationsSystem _notificationsSystem;

        public double Balance { get; private set; } = 0;
        public double InterestRate { get; private set; } = 0;
        public List<Loan> Loans { get; private set; } = new List<Loan>();
        public List<Investment> Investments { get; private set; } = new List<Investment>();

        private Account()
        {
            _transfersSystem = new TransfersSystem(this);
            _loansSystem = new LoansSystem(this);
            _investmentsSystem = new InvestmentsSystem(this);
        }

        public static Account GetEmptyAccount() => new Account();
        
        public void ChangeBalance(double balanceChange) =>
            Balance += balanceChange;

        public void EnableNotifications()
        {
            _notificationsSystem = new NotificationsSystem();
            _transfersSystem.Subscribe(_notificationsSystem);
            _loansSystem.Subscribe(_notificationsSystem);
            _investmentsSystem.Subscribe(_notificationsSystem);
        }

        public void SetInterestRate(double interestRate) =>
            InterestRate = interestRate;

        public void Evaluate()
        {
            Balance *= (1 + InterestRate);
            Loans.ForEach(l => l.Evaluate());
            Investments.ForEach(i => i.Evaluate());
        }

        public void SendTransfer(double amount) =>
            _transfersSystem.SendTransfer(amount);

        public void MakeDeposit(double amount) =>
            _transfersSystem.MakeDeposit(amount);

        public void TakeNewLoan(double amount, LoanType type) =>
            _loansSystem.TakeLoan(amount, type);

        public void PayOffLoan(Guid id, double amount) =>
            _loansSystem.PayLoan(id, amount);

        public void InvestMoney(double amount, StrategyType type) =>
            _investmentsSystem.InvestMoney(amount, type);

        public override string ToString()
        {
            var infoBuilder = new StringBuilder()
                .AppendLine("--- Account information ---")
                .AppendLine($"    * Balance: {Balance.ToString("F2")}")
                .AppendLine($"    * Interest rate: {InterestRate.ToString("F2")}");

            if (Loans.Any())
            {
                infoBuilder.AppendLine("    * Loans:");
            }
            foreach (var loan in Loans)
            {
                infoBuilder.AppendLine($"        * id: {loan.Id}, balance: {loan.Balance.ToString("F2")}, rate: {loan.InterestRate.ToString("F2")}");
            }

            if (Investments.Any())
            {
                infoBuilder.AppendLine("    * Investments:");
            }
            foreach (var investment in Investments)
            {
                infoBuilder.AppendLine($"        * name: {investment.Name}, balance: {investment.Balance.ToString("F2")}, volatility: {investment.Volatility.ToString("F2")}");
            }

            return infoBuilder.AppendLine().ToString();
        }
    }
}
