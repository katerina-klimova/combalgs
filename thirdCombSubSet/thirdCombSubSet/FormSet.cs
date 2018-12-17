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
            
            int munCnt = (int)nudMutCnt.Value;
            if (munCnt > items.Length - 1) munCnt = 1;
            int cntParChoms = (int)nudParentChrom.Value;
            int cntChoms = (int)nudChrom.Value;
            if (cntParChoms >= cntChoms) cntParChoms = cntChoms/2;

            ExactAlgorithm exactAlg = new ExactAlgorithm();
            GeneticAlgorithm geneticAlg = new GeneticAlgorithm(cntChoms, items, (int)nudMutation.Value, munCnt,cntParChoms);

            int[] resEx = exactAlg.run(items);
            int[] resGen = geneticAlg.run((int)nudSteps.Value);

            output(tbExact, tbTimeEx, resEx, exactAlg.getWorkTime());
            output(tbGen, tbTimeGen, resGen, geneticAlg.getWorkTime());
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

        private void output(TextBox tb,TextBox tbTime, int[] res, long time)
        {
            if (res != null)
            {
                foreach (int el in res)
                {
                    tb.AppendText(el + " ");
                }
                tbTime.Text = ((double)time / 100000).ToString();
            }
            else
            {
                tb.AppendText("Решения не существует!");
            }
        }
        
    }
}
