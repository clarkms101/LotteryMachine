using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryMachineForm
{
    public partial class Form1 : Form
    {
        private LotteryMachine _lottery;

        public Form1()
        {
            InitializeComponent();
            ResetLotteryMachine();
        }

        /// <summary>
        /// 洗球
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            _lottery.Shuffle();
            ShowOriginalLotteryBallList();
        }

        /// <summary>
        /// 抽一球
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetOneNumber_Click(object sender, EventArgs e)
        {
            var ballNumber = _lottery.GetOneNumber();
            txtResult.Text += $"{ballNumber}\r\n";
            ShowOriginalLotteryBallList();
        }

        /// <summary>
        /// 自動抽球
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAutoGetBallNumber_Click(object sender, EventArgs e)
        {
            while (_lottery.GetBallList().Count != 0)
            {
                await Task.Delay(100);
                var ballNumber = _lottery.GetOneNumber();
                txtResult.Text += $"{ballNumber}\r\n";
                ShowOriginalLotteryBallList();
            }
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetLotteryMachine();
        }

        /// <summary>
        /// 顯示樂透機裡面樂透球
        /// </summary>
        private void ShowOriginalLotteryBallList()
        {
            txtOriginalLotteryBallList.Text = "";
            foreach (var ballNumber in _lottery.GetBallList())
            {
                txtOriginalLotteryBallList.Text += $"{ballNumber}\r\n";
            }
        }

        /// <summary>
        /// 重置樂透機
        /// </summary>
        private void ResetLotteryMachine()
        {
            var ballQty = Convert.ToInt32(this.txtMaxBallQty.Text);
            _lottery = new LotteryMachine(ballQty);
            ShowOriginalLotteryBallList();
            txtResult.Text = "";
        }
    }
}