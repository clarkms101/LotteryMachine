using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LotteryMachineForm
{
    /// <summary>
    /// 樂透機
    /// </summary>
    internal class LotteryMachine
    {
        private List<int> _ballList;

        public LotteryMachine(int maxAmountOfBalls)
        {
            // 產生裡面的樂透球
            _ballList = Enumerable.Range(1, maxAmountOfBalls).ToList();
        }

        /// <summary>
        /// 隨機抽一球
        /// </summary>
        /// <returns></returns>
        public int GetOneNumber()
        {
            // 取得隨機的樂透球
            var ball = GetRandomBall();
            // 移除被取出的樂透球
            _ballList.RemoveAll(n => n == ball);
            return ball;
        }

        /// <summary>
        /// 洗球
        /// </summary>
        public void Shuffle()
        {
            var tempBallList = new List<int>();
            while (_ballList.Count != 0)
            {
                // 取得隨機的樂透球
                var ball = GetRandomBall();
                // 移除被取出的樂透球
                _ballList.RemoveAll(n => n == ball);
                // 放入暫存結果
                tempBallList.Add(ball);
            }

            // 將洗完的結果放回樂透機
            _ballList = tempBallList;
        }

        /// <summary>
        /// 取得目前樂透機裡的樂透球
        /// </summary>
        /// <returns></returns>
        public List<int> GetBallList()
        {
            return _ballList;
        }

        /// <summary>
        /// 從樂透機取得隨機一個樂透球
        /// </summary>
        /// <returns></returns>
        private int GetRandomBall()
        {
            var count = _ballList.Count;
            // 沒球了
            if (count == 0)
            {
                return default;
            }

            var random = new Random();
            var index = random.Next(count);
            var ball = _ballList[index];
            return ball;
        }
    }
}