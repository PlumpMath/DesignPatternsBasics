using System;
using static System.Console;

namespace BankingSystem.Subsystems
{
    public class NotificationsSystem : IObserver
    {
        public void SendTextToClient(string content)
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine(content);
            ResetColor();
        }
    }
}
