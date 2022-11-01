namespace LotteryMachineForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxBallQty = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAutoGetBallNumber = new System.Windows.Forms.Button();
            this.btnGetOneNumber = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtOriginalLotteryBallList = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaxBallQty);
            this.splitContainer1.Panel1.Controls.Add(this.btnReset);
            this.splitContainer1.Panel1.Controls.Add(this.btnAutoGetBallNumber);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetOneNumber);
            this.splitContainer1.Panel1.Controls.Add(this.btnShuffle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(759, 450);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "輸入球數量";
            // 
            // txtMaxBallQty
            // 
            this.txtMaxBallQty.Location = new System.Drawing.Point(24, 50);
            this.txtMaxBallQty.Name = "txtMaxBallQty";
            this.txtMaxBallQty.Size = new System.Drawing.Size(97, 27);
            this.txtMaxBallQty.TabIndex = 4;
            this.txtMaxBallQty.Text = "100";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(155, 43);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 39);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAutoGetBallNumber
            // 
            this.btnAutoGetBallNumber.Location = new System.Drawing.Point(539, 43);
            this.btnAutoGetBallNumber.Name = "btnAutoGetBallNumber";
            this.btnAutoGetBallNumber.Size = new System.Drawing.Size(94, 39);
            this.btnAutoGetBallNumber.TabIndex = 2;
            this.btnAutoGetBallNumber.Text = "自動抽球";
            this.btnAutoGetBallNumber.UseVisualStyleBackColor = true;
            this.btnAutoGetBallNumber.Click += new System.EventHandler(this.btnAutoGetBallNumber_Click);
            // 
            // btnGetOneNumber
            // 
            this.btnGetOneNumber.Location = new System.Drawing.Point(414, 43);
            this.btnGetOneNumber.Name = "btnGetOneNumber";
            this.btnGetOneNumber.Size = new System.Drawing.Size(94, 39);
            this.btnGetOneNumber.TabIndex = 1;
            this.btnGetOneNumber.Text = "抽一球";
            this.btnGetOneNumber.UseVisualStyleBackColor = true;
            this.btnGetOneNumber.Click += new System.EventHandler(this.btnGetOneNumber_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(280, 43);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(100, 39);
            this.btnShuffle.TabIndex = 0;
            this.btnShuffle.Text = "洗球";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtOriginalLotteryBallList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtResult);
            this.splitContainer2.Size = new System.Drawing.Size(759, 340);
            this.splitContainer2.SplitterDistance = 380;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtOriginalLotteryBallList
            // 
            this.txtOriginalLotteryBallList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOriginalLotteryBallList.Location = new System.Drawing.Point(0, 0);
            this.txtOriginalLotteryBallList.Multiline = true;
            this.txtOriginalLotteryBallList.Name = "txtOriginalLotteryBallList";
            this.txtOriginalLotteryBallList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOriginalLotteryBallList.Size = new System.Drawing.Size(376, 336);
            this.txtOriginalLotteryBallList.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(371, 336);
            this.txtResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "樂透洗球機";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtOriginalLotteryBallList;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGetOneNumber;
        private System.Windows.Forms.Button btnAutoGetBallNumber;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMaxBallQty;
        private System.Windows.Forms.Label label1;
    }
}
