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
 * Все не печатать, только число
*/
namespace WindowsFormsApp2
{
    public partial class SecondRestForm : Form
    {
        int restC = 0;
        int[] cashBox = new int[7];
        int[] listCoins = { 1, 5, 10, 50, 100, 200, 500 };

        public SecondRestForm()
        {
            InitializeComponent();
            num1.Maximum = Decimal.MaxValue;
            num5.Maximum = Decimal.MaxValue;
            num10.Maximum = Decimal.MaxValue;
            num50.Maximum = Decimal.MaxValue;
            num100.Maximum = Decimal.MaxValue;
            num200.Maximum = Decimal.MaxValue;
            num500.Maximum = Decimal.MaxValue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            lbVarsCnt.Text = "";
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
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат ввода монет продавца!");
                return;
            }

            try
            {
                restC = Convert.ToInt32(numRub.Value * 100 + numCop.Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат ввода цены!");
                return;
            }
            if (restC > 0)
            {
                int variants = Algorithm.countOfWays(listCoins,cashBox,7,restC);
                if (variants == 0)
                {
                    MessageBox.Show("Невозможно дать сдачу!");
                }
                else
                    MessageBox.Show("Всего вариантов дать сдачу: " + variants.ToString());
            }
            else
                MessageBox.Show("Сдачи нет!");

        }
        
    }
}
