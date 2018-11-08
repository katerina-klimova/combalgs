using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Необходимо подсчитать кол-во вариантов и вывести их для сдачи суммы от 
 * 1к … до 10р монетами достоинством 1к,5к,10к,50к,1р,2р,5р. 
 * Набор монет задается пользователем. 
 * Использовать только монеты продавца
*/
namespace WindowsFormsApp2
{
    public partial class SecondRestForm : Form
    {
        int restC = 0;
        int[] cashBox = new int[8];
        int[] listCoins = { 1, 5, 10, 50, 100, 200, 500, 1000 };

        public SecondRestForm()
        {
            InitializeComponent();
        }

        private string toLine(int [] arr)
        {
            string result = "";
            if (arr[0] > 0)
            {
                result += arr[0] + " монет по 1 копейке, ";
            }
            for (int i = 1; i < 4; i++)
            {
                if (arr[i] > 0) {
                    result += arr[i] + " монет по " + listCoins[i] +" копеек, ";
                }
            }
            if (arr[4] > 0)
            {
                result += arr[4] + " монет по 1 рублю, ";
            }
            if (arr[5] > 0)
            {
                result += arr[5] + " монет по 2 рубля, ";
            }
            for (int i = 6; i < 8 ; i++)
            {
                if (arr[i] > 0)
                {
                    result += arr[i] + " монет по " + listCoins[i]/100 + " рублей, ";
                }
            }
            return result;
        }

        private void rest()
        {
            try
            {
                restC = Convert.ToInt32(Math.Round(double.Parse(txtMoney.Text), 2) * 100 - 
                    Math.Round(double.Parse(txtPrice.Text), 2) * 100);

            }
            catch (Exception e)
            {
                throw e;
            }

            if (restC > 0.001)
            {
                lbRest.Text = "Сдача: " + restC / 100 + "." + restC % 100;
            }
            else if (restC == 0)
            {
                lbRest.Text = "Сдачи нет.";
            }
            else
            {
                lbRest.Text = "Недостаточно денег!";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            lbRests.Items.Clear();
            lbVarsCnt.Text = "";
            try
            {
                cashBox[0] = Convert.ToInt32(num1.Value);
                cashBox[1] = Convert.ToInt32(num5.Value);
                cashBox[2] = Convert.ToInt32(num10.Value);
                cashBox[3] = Convert.ToInt32(num50.Value);
                cashBox[4] = Convert.ToInt32(num100.Value);
                cashBox[5] = Convert.ToInt32(num200.Value);
                cashBox[6] = Convert.ToInt32(num500.Value);
                cashBox[7] = Convert.ToInt32(num1000.Value);
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

            Algorithm alg = new Algorithm(listCoins, restC, cashBox);
            List<int[]> variants = alg.restCoins();
            if(variants.Count == 0)
            {
                MessageBox.Show("Невозможно дать сдачу!");
            }
            foreach (int[] arr in variants)
            {
                lbRests.Items.Add(toLine(arr));
            }
            lbVarsCnt.Text = "Всего вариантов дать сдачу: " +lbRests.Items.Count.ToString();
        }
        
    }
}
