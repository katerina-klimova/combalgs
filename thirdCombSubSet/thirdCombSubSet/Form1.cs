using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace thirdCombSubSet
{
    public partial class FormSet : Form
    {
        public FormSet()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbSet.Items.Add(nudElem.Value);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lbSet.Items.Remove(lbSet.SelectedItem);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            clearAll();
            int cnt = lbSet.Items.Count;
            int[] items = new int[cnt];
            for(int i = 0; i < cnt; i++)
            {
                items[i] = Convert.ToInt32(lbSet.Items[i]);
            }

            Algorithm alg = new Algorithm();

            //long curTimeEx = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int[] resEx = alg.exact(items);

            stopWatch.Stop();
            long curTimeEx = stopWatch.ElapsedTicks;
            
            if (resEx != null)
            {
                foreach (int el in resEx)
                {
                    tbExact.AppendText(el + " ");
                }
                tbTimeEx.Text = ((double)curTimeEx/10000).ToString();
            }
            else
            {
                tbExact.AppendText("Решения не существует!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            lbSet.Items.Clear();
        }

        private void clearAll()
        {
            tbExact.Clear();
            tbTimeEx.Clear();
            tbTimeGen.Clear();
            tbGen.Clear();
        }
    }
}
