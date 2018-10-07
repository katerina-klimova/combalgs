using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combinatorFirstRest
{
    public partial class RestForm : Form
    {
        double restC =0;
        int[] cashBox = { 100, 100, 100, 100, 100, 100, 100, 100 };
        int[] listCoins = {1, 5, 10, 50, 100, 200, 500, 1000 };
        bool found = false;
        public RestForm()
        {
            InitializeComponent();
            cashBoxPrint();
        }

        private void cashBoxPrint()
        {
            lbCash001.Text = cashBox[0].ToString();
            lbCash005.Text = cashBox[1].ToString();
            lbCash01.Text = cashBox[2].ToString();
            lbCash05.Text = cashBox[3].ToString();

            lbCash1.Text = cashBox[4].ToString();
            lbCash2.Text = cashBox[5].ToString();
            lbCash5.Text = cashBox[6].ToString();
            lbCash10.Text = cashBox[7].ToString();
        }
        
        private void rest()
        {
            try {
                restC = double.Parse(cmbMoney.Text)*100 - double.Parse(cmbPrice.Text)*100;
                restC = Math.Truncate(restC);
                
            }
            catch(Exception e)
            {
                throw e; 
            }
            
            if (restC > 0.001)
            {
                lbRest.Text = "Сдача: " + restC/100;
            }
            else if (Math.Abs(restC) < 0.001)
            {
                lbRest.Text = "Сдачи нет.";
            }
            else{
                lbRest.Text = "Недостаточно денег!";
            }
            
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            try
            {
                rest();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат ввода!");
                return;
            }
            
            found = false;
            int[] coins = restCoins();

            label001.Text = "Монет: " + coins[0];
            label005.Text = "Монет: " + coins[1];
            label01.Text = "Монет: " + coins[2];
            label05.Text = "Монет: " + coins[3];

            label1.Text = "Монет: " + coins[4];
            label2.Text = "Монет: " + coins[5];
            label5.Text = "Монет: " + coins[6];
            label10.Text = "Монет: " + coins[7];


            if (restC > 0.001)
            {
                for(int i = 0; i < cashBox.Length; i++)
                {
                    cashBox[i] -= coins[i];
                }
                cashBoxPrint();
            }
        }
        
        private int[] recRest(int k, int[] coins,int curSum)
        {
            
            if (Math.Abs(curSum - restC) < 0.001)
            {
                found = true;
                return coins;
            }
            if (k > 0)
            {
                for(int i = 0; (i < listCoins.Length)&&(!found); i++)
                {
                    coins[i]++;
                    recRest(k-1, coins , curSum + listCoins[i]);
                    if (!found)
                        coins[i]--;
                }
            }
            
            return coins;
        }

        
        /*Сколько монет каждого номинала надо отдать*/
        private int[] restCoins()
        {
            int[] result = new int[8];
            int i = 0;
            while (!found)
            {
                result = recRest(++i,result,0);
            }
            int cnt=0;
            for(int j = 0; j < result.Length; j++)
            {
                cnt += result[j];
            }
            lbCount.Text = "Всего монет: " + cnt; ;
            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
