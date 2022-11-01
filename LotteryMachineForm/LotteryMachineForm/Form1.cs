using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryMachineForm
{
    public partial class Form1 : Form
    {
        private readonly LotteryMachineLogic _lottery;

        public Form1()
        {
            InitializeComponent();
            _lottery = new LotteryMachineLogic();
        }

        private void ShowOriginalLotteryBallList()
        {
            this.txtOriginalLotteryBallList.Text = "";
            foreach (var number in _lottery.GetLotteryBallNumber())
            {
                this.txtOriginalLotteryBallList.Text += $"{number}\r\n";
            }
        }


        private void btnShuffle_Click(object sender, EventArgs e)
        {
            _lottery.Shuffle();
            ShowOriginalLotteryBallList();
        }

        private void btnGetOneNumber_Click(object sender, EventArgs e)
        {
            var number = _lottery.GetOneNumber();
            txtResult.Text += $"{number}\r\n";
            ShowOriginalLotteryBallList();
        }

        private void btnGetAllNumber_Click(object sender, EventArgs e)
        {
            var numbers = _lottery.GetAllNumber();
            foreach (var number in numbers)
            {
                txtResult.Text += $"{number}\r\n";
                ShowOriginalLotteryBallList();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var ballQty = Convert.ToInt32(this.txtMaxBallQty.Text);
            _lottery.GenerateLotteryBallNumber(ballQty);
            ShowOriginalLotteryBallList();
            this.txtResult.Text = "";
        }
    }
}