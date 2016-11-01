using System;
using System.Threading;
using static System.Console;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("First president:");
            var president = CzechPresident.GetCurrentPresident();
            Thread.Sleep(1500);
            WriteLine(president.IntroduceYourself());

            WriteLine("\nSecond president:");
            Thread.Sleep(2500);
            var otherPresident = CzechPresident.GetCurrentPresident();
            WriteLine(otherPresident.IntroduceYourself());

            WriteLine("\nAre they the same?");
            WriteLine(president.Equals(otherPresident));

            ReadKey();
        }
    }
}
