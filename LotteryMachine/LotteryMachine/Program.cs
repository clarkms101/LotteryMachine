using System;
using System.Threading.Tasks;

namespace LotteryMachine
{
    internal static class Program
    {
        private const int MaxAmountOfBalls = 100;
        private const int MillisecondsDelay = 100;

        private static async Task Main(string[] args)
        {
            var lotteryMachineLogic = new LotteryMachineLogic(MaxAmountOfBalls);

            await ShowResult(lotteryMachineLogic.GetOneNumber());
            await ShowResult(lotteryMachineLogic.GetOneNumber());

            lotteryMachineLogic.Shuffle();
            Console.WriteLine("重新洗球!");

            await ShowResult(lotteryMachineLogic.GetOneNumber());
            await ShowResult(lotteryMachineLogic.GetOneNumber());
            await ShowResult(lotteryMachineLogic.GetOneNumber());

            lotteryMachineLogic.Shuffle();
            Console.WriteLine("重新洗球!");

            var result = lotteryMachineLogic.GetAllNumber();
            foreach (var s in result)
            {
                await ShowResult(s);
            }
        }

        private static async Task ShowResult(int number)
        {
            await Task.Delay(MillisecondsDelay);
            Console.WriteLine(number);
        }
    }
}