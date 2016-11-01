using BankingSystem.Investments;
using System;

namespace BankingSystem
{
    public interface ITransactionSystem
    {
        void SendTransfer(double amount);
        void MakeDeposit(double amount);
        void TakeNewLoan(double amount, LoanType type);
        void PayOffLoan(Guid id, double amount);
        void InvestMoney(double amount, StrategyType type);
    }
}