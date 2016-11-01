using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First president:");
            var president = CzechPresident.GetCurrentPresident();
            Thread.Sleep(1500);
            Console.WriteLine(president.IntroduceYourself());

            Console.WriteLine("\nSecond president:");
            Thread.Sleep(2500);
            var otherPresident = CzechPresident.GetCurrentPresident();
            Console.WriteLine(otherPresident.IntroduceYourself());

            Console.WriteLine("\nAre they the same?");
            Console.WriteLine(president.Equals(otherPresident));

            Console.ReadKey();
        }
    }
}
