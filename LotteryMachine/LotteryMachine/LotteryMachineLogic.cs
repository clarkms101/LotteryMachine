using System;
using System.Collections.Generic;
using System.Linq;

namespace LotteryMachine
{
    /// <summary>
    /// 樂透機邏輯
    /// </summary>
    public class LotteryMachineLogic
    {
        private List<int> _lotteryBallList;

        public LotteryMachineLogic(int maxAmountOfBalls)
        {
            // 產生樂透球
            _lotteryBallList = Enumerable.Range(1, maxAmountOfBalls).ToList();
        }

        /// <summary>
        /// 隨機抽一球
        /// </summary>
        /// <returns></returns>
        public int GetOneNumber()
        {
            var count = _lotteryBallList.Count;
            // 沒球了
            if (count == 0)
            {
                return default;
            }

            var random = new Random();
            // 取出樂透球隨機一個號碼
            var index = random.Next(count);
            var randomBallNumber = _lotteryBallList[index];
            // 移除被取出的樂透球
            _lotteryBallList.RemoveAll(n => n == randomBallNumber);
            return randomBallNumber;
        }

        /// <summary>
        /// 抽全部(剩餘)的球
        /// </summary>
        /// <returns></returns>
        public List<int> GetAllNumber()
        {
            var result = new List<int>();
            while (_lotteryBallList.Count != 0)
            {
                var ballNumber = GetOneNumber();
                result.Add(ballNumber);
            }

            return result;
        }

        /// <summary>
        /// 洗球
        /// </summary>
        public void Shuffle()
        {
            _lotteryBallList = GetAllNumber();
        }
    }
}