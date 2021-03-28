using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TibiaDiceCalc
{
    public partial class TibiaDiceCalc : Form
    {
        
        public TibiaDiceCalc()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            lbBalanceAmount.Text = tbDeposit.Text;
            tbDeposit.Clear();
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            if (rbHighLow.Checked)
            {
                double tmp,tmp1;
                if (double.TryParse(lbHighLowAmount.Text, out tmp)&& double.TryParse(lbBalanceAmount.Text, out tmp1))
                {
                    lbBalanceAmount.Text = (tmp + tmp1).ToString();
                }
                
            }
            if (rbNumber.Checked)
            {
                double tmp, tmp1;
                if (double.TryParse(lbNumberAmount.Text, out tmp) && double.TryParse(lbBalanceAmount.Text, out tmp1))
                {
                    lbBalanceAmount.Text = (tmp + tmp1).ToString();
                }
                
            }
            Refresh();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            double amount;
            if(double.TryParse(tbAmountBet.Text,out amount))
            {
                lbHighLowAmount.Text = (1.8 * amount).ToString();
            }
            if (double.TryParse(tbAmountBet.Text,out amount))
            {
                lbNumberAmount.Text = (5 * amount).ToString();
            }
            else
            {
                MessageBox.Show("it's not a number");
            }


        }

        private void btnWidthdraw_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"you need to pay: " + lbBalanceAmount.Text);
            lbBalanceAmount.Text = null;
        }

        private void btnLoss_Click(object sender, EventArgs e)
        {
            double tmp, tmp1;
            try
            {
                double.TryParse(tbAmountBet.Text, out tmp);
                double.TryParse(lbBalanceAmount.Text, out tmp1);
                lbBalanceAmount.Text = (tmp1 - tmp).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Someting going wrong. {ex.ToString()}");
            }
            Refresh();
            
        }
        private void Refresh()
        {
            rbNumber.Checked = false;
            rbHighLow.Checked = false;
            lbNumberAmount.Text = null;
            lbHighLowAmount.Text = null;
            tbAmountBet.Clear();
        }
    }
}
