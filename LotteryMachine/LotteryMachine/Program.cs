using System;

namespace LotteryMachine
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var lotteryMachineLogic = new LotteryMachineLogic(100);

            Console.WriteLine(lotteryMachineLogic.GetOneNumber());
            Console.WriteLine(lotteryMachineLogic.GetOneNumber());

            lotteryMachineLogic.Shuffle();

            Console.WriteLine(lotteryMachineLogic.GetOneNumber());
            Console.WriteLine(lotteryMachineLogic.GetOneNumber());
            Console.WriteLine(lotteryMachineLogic.GetOneNumber());

            lotteryMachineLogic.Shuffle();

            var result = lotteryMachineLogic.GetAllNumber();
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}