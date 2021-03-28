
namespace TibiaDiceCalc
{
    partial class TibiaDiceCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTransactions = new System.Windows.Forms.GroupBox();
            this.btnWidthdraw = new System.Windows.Forms.Button();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblBetAmount = new System.Windows.Forms.Label();
            this.tbAmountBet = new System.Windows.Forms.TextBox();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.lbBalanceAmount = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lbBalance = new System.Windows.Forms.Label();
            this.gbGames = new System.Windows.Forms.GroupBox();
            this.rbNumber = new System.Windows.Forms.RadioButton();
            this.lbNumberAmount = new System.Windows.Forms.Label();
            this.lbNumberTxt = new System.Windows.Forms.Label();
            this.rbHighLow = new System.Windows.Forms.RadioButton();
            this.lbHighLowAmount = new System.Windows.Forms.Label();
            this.lbHighLowTxt = new System.Windows.Forms.Label();
            this.btnWin = new System.Windows.Forms.Button();
            this.btnLoss = new System.Windows.Forms.Button();
            this.gbTransactions.SuspendLayout();
            this.gbGames.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTransactions
            // 
            this.gbTransactions.Controls.Add(this.btnWidthdraw);
            this.gbTransactions.Controls.Add(this.btnBet);
            this.gbTransactions.Controls.Add(this.lblBetAmount);
            this.gbTransactions.Controls.Add(this.tbAmountBet);
            this.gbTransactions.Controls.Add(this.tbDeposit);
            this.gbTransactions.Controls.Add(this.lbBalanceAmount);
            this.gbTransactions.Controls.Add(this.btnDeposit);
            this.gbTransactions.Controls.Add(this.lbBalance);
            this.gbTransactions.Location = new System.Drawing.Point(12, 12);
            this.gbTransactions.Name = "gbTransactions";
            this.gbTransactions.Size = new System.Drawing.Size(265, 135);
            this.gbTransactions.TabIndex = 0;
            this.gbTransactions.TabStop = false;
            this.gbTransactions.Text = "Transactions";
            // 
            // btnWidthdraw
            // 
            this.btnWidthdraw.Location = new System.Drawing.Point(158, 105);
            this.btnWidthdraw.Name = "btnWidthdraw";
            this.btnWidthdraw.Size = new System.Drawing.Size(84, 23);
            this.btnWidthdraw.TabIndex = 7;
            this.btnWidthdraw.Text = "Withdraw";
            this.btnWidthdraw.UseVisualStyleBackColor = true;
            this.btnWidthdraw.Click += new System.EventHandler(this.btnWidthdraw_Click);
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(18, 106);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 6;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblBetAmount
            // 
            this.lblBetAmount.AutoSize = true;
            this.lblBetAmount.Location = new System.Drawing.Point(15, 83);
            this.lblBetAmount.Name = "lblBetAmount";
            this.lblBetAmount.Size = new System.Drawing.Size(65, 13);
            this.lblBetAmount.TabIndex = 5;
            this.lblBetAmount.Text = "Bet Amount:";
            // 
            // tbAmountBet
            // 
            this.tbAmountBet.Location = new System.Drawing.Point(158, 80);
            this.tbAmountBet.Name = "tbAmountBet";
            this.tbAmountBet.Size = new System.Drawing.Size(84, 20);
            this.tbAmountBet.TabIndex = 4;
            // 
            // tbDeposit
            // 
            this.tbDeposit.Location = new System.Drawing.Point(158, 54);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(84, 20);
            this.tbDeposit.TabIndex = 3;
            // 
            // lbBalanceAmount
            // 
            this.lbBalanceAmount.AutoSize = true;
            this.lbBalanceAmount.Location = new System.Drawing.Point(110, 26);
            this.lbBalanceAmount.Name = "lbBalanceAmount";
            this.lbBalanceAmount.Size = new System.Drawing.Size(0, 13);
            this.lbBalanceAmount.TabIndex = 1;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(18, 51);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(15, 26);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(49, 13);
            this.lbBalance.TabIndex = 0;
            this.lbBalance.Text = "Balance:";
            // 
            // gbGames
            // 
            this.gbGames.Controls.Add(this.rbNumber);
            this.gbGames.Controls.Add(this.lbNumberAmount);
            this.gbGames.Controls.Add(this.lbNumberTxt);
            this.gbGames.Controls.Add(this.rbHighLow);
            this.gbGames.Controls.Add(this.lbHighLowAmount);
            this.gbGames.Controls.Add(this.lbHighLowTxt);
            this.gbGames.Location = new System.Drawing.Point(12, 172);
            this.gbGames.Name = "gbGames";
            this.gbGames.Size = new System.Drawing.Size(599, 252);
            this.gbGames.TabIndex = 1;
            this.gbGames.TabStop = false;
            this.gbGames.Text = "Games";
            // 
            // rbNumber
            // 
            this.rbNumber.AutoSize = true;
            this.rbNumber.Location = new System.Drawing.Point(18, 122);
            this.rbNumber.Name = "rbNumber";
            this.rbNumber.Size = new System.Drawing.Size(62, 17);
            this.rbNumber.TabIndex = 5;
            this.rbNumber.Text = "Number";
            this.rbNumber.UseVisualStyleBackColor = true;
            // 
            // lbNumberAmount
            // 
            this.lbNumberAmount.AutoSize = true;
            this.lbNumberAmount.Location = new System.Drawing.Point(110, 106);
            this.lbNumberAmount.Name = "lbNumberAmount";
            this.lbNumberAmount.Size = new System.Drawing.Size(0, 13);
            this.lbNumberAmount.TabIndex = 4;
            // 
            // lbNumberTxt
            // 
            this.lbNumberTxt.AutoSize = true;
            this.lbNumberTxt.Location = new System.Drawing.Point(15, 106);
            this.lbNumberTxt.Name = "lbNumberTxt";
            this.lbNumberTxt.Size = new System.Drawing.Size(47, 13);
            this.lbNumberTxt.TabIndex = 3;
            this.lbNumberTxt.Text = "Number:";
            // 
            // rbHighLow
            // 
            this.rbHighLow.AutoSize = true;
            this.rbHighLow.Location = new System.Drawing.Point(18, 53);
            this.rbHighLow.Name = "rbHighLow";
            this.rbHighLow.Size = new System.Drawing.Size(72, 17);
            this.rbHighLow.TabIndex = 2;
            this.rbHighLow.Text = "High/Low";
            this.rbHighLow.UseVisualStyleBackColor = true;
            // 
            // lbHighLowAmount
            // 
            this.lbHighLowAmount.AutoSize = true;
            this.lbHighLowAmount.Location = new System.Drawing.Point(110, 37);
            this.lbHighLowAmount.Name = "lbHighLowAmount";
            this.lbHighLowAmount.Size = new System.Drawing.Size(0, 13);
            this.lbHighLowAmount.TabIndex = 1;
            // 
            // lbHighLowTxt
            // 
            this.lbHighLowTxt.AutoSize = true;
            this.lbHighLowTxt.Location = new System.Drawing.Point(15, 37);
            this.lbHighLowTxt.Name = "lbHighLowTxt";
            this.lbHighLowTxt.Size = new System.Drawing.Size(66, 13);
            this.lbHighLowTxt.TabIndex = 0;
            this.lbHighLowTxt.Text = "High / Low: ";
            // 
            // btnWin
            // 
            this.btnWin.Location = new System.Drawing.Point(373, 15);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(173, 58);
            this.btnWin.TabIndex = 2;
            this.btnWin.Text = "Win";
            this.btnWin.UseVisualStyleBackColor = true;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // btnLoss
            // 
            this.btnLoss.Location = new System.Drawing.Point(373, 89);
            this.btnLoss.Name = "btnLoss";
            this.btnLoss.Size = new System.Drawing.Size(173, 58);
            this.btnLoss.TabIndex = 3;
            this.btnLoss.Text = "Loss";
            this.btnLoss.UseVisualStyleBackColor = true;
            this.btnLoss.Click += new System.EventHandler(this.btnLoss_Click);
            // 
            // TibiaDiceCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 460);
            this.Controls.Add(this.btnLoss);
            this.Controls.Add(this.btnWin);
            this.Controls.Add(this.gbGames);
            this.Controls.Add(this.gbTransactions);
            this.Name = "TibiaDiceCalc";
            this.Text = "Tibia Dice Calculator";
            this.gbTransactions.ResumeLayout(false);
            this.gbTransactions.PerformLayout();
            this.gbGames.ResumeLayout(false);
            this.gbGames.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTransactions;
        private System.Windows.Forms.Label lbBalanceAmount;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.Label lblBetAmount;
        private System.Windows.Forms.TextBox tbAmountBet;
        private System.Windows.Forms.GroupBox gbGames;
        private System.Windows.Forms.Label lbHighLowTxt;
        private System.Windows.Forms.Label lbHighLowAmount;
        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Button btnWidthdraw;
        private System.Windows.Forms.RadioButton rbHighLow;
        private System.Windows.Forms.Label lbNumberTxt;
        private System.Windows.Forms.RadioButton rbNumber;
        private System.Windows.Forms.Label lbNumberAmount;
        private System.Windows.Forms.Button btnLoss;
    }
}

