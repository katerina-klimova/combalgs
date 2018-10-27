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
        int restC =0;
        int[] cashBox = new int [8];
        int[] listCoins = {1, 5, 10, 50, 100, 200, 500, 1000 };
        
        public RestForm()
        {
            InitializeComponent();
        }
        
        private void rest()
        {
            try {
                restC = Convert.ToInt32(Math.Round(double.Parse(cmbMoney.Text),2) * 100 - Math.Round(double.Parse(cmbPrice.Text),2)*100);
                //restC = Math.Truncate(restC);
                
            }
            catch(Exception e)
            {
                throw e; 
            }
            
            if (restC > 0.001)
            {
                lbRest.Text = "Сдача: " + restC/100 + "."+restC % 100;
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
                cashBox[0] = int.Parse(txt001.Text);
                cashBox[1] = int.Parse(txt005.Text);
                cashBox[2] = int.Parse(txt01.Text);
                cashBox[3] = int.Parse(txt05.Text);
                cashBox[4] = int.Parse(txt1.Text);
                cashBox[5] = int.Parse(txt2.Text);
                cashBox[6] = int.Parse(txt5.Text);
                cashBox[7] = int.Parse(txt10.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат ввода монет продавца!");
                return;
            }

            try
            {
                rest();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат ввода цены!");
                return;
            }

            

            int[] coins= new int[listCoins.Length];

            Algorithm alg = new Algorithm(listCoins,restC,cashBox);
            try
            {
                int[] combination = alg.restCoins();
                int i = 0;
                int cnt=0;
                while (restC!=0)
                {
                    restC -= combination[i];
                    switch (combination[i])
                    {
                        case 1: coins[0]++;
                            break;
                        case 5:
                            coins[1]++;
                            break;
                        case 10:
                            coins[2]++;
                            break;
                        case 50:
                            coins[3]++;
                            break;
                        case 100:
                            coins[4]++;
                            break;
                        case 200:
                            coins[5]++;
                            break;
                        case 500:
                            coins[6]++;
                            break;
                        case 1000:
                            coins[7]++;
                            break;
                    }
                    cnt++;
                    i++;
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно дать сдачу!");
                return;
            }

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
            }
        }
        
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
