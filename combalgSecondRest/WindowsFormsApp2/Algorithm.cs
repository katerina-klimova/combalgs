using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Algorithm
    {
        private int[] listCoins;//номиналы монет
        int rest = 0; //сумма сдачи
        int[] cashBox; //количество всех монет каждого номинала
        int[] data;
        List<int[]> result;

        public Algorithm(int[] _listCoins, int _rest, int[] _cashBox)
        {
            listCoins = _listCoins;
            rest = _rest;
            cashBox = _cashBox;
            result = new List<int[]>();
        }

        private bool isContains(List<int[]> input, int [] arr)
        {
            foreach(int[] member in input)
            {
                if (member.SequenceEqual(arr)) return true;
            }
            return false;
        }

        private void recRest(int k, int[] coins, int curSum)
        {

            if ((rest == curSum) && (k==0) )
            {
                int[] list = new int[listCoins.Length];
                for(int index = 0; index < coins.Length; index++)
                {
                    list[index] = coins[index];
                }
                if(!isContains(result,list))
                    result.Add(list);
                return;
            }
            if (k > 0)
            {
                for (int i = 0; i <listCoins.Length ; i++)
                {
                    if (coins[i] < cashBox[i])
                    {
                        coins[i]++;
                        recRest(k - 1, coins, curSum + listCoins[i]);
                        coins[i]--;
                    }
                }
            }
        }


        public List<int[]> restCoins()
        {
            int sellerCoinsCnt = 0;
            for (int j = 0; j < cashBox.Length; j++)
            {
                sellerCoinsCnt += cashBox[j];
            }
            data = new int[sellerCoinsCnt];
            int k = 0;
            for (int i = 0; i < cashBox.Length; i++)
            {
                for (int j = 0; j < cashBox[i]; j++)
                {
                    data[k] = listCoins[i];
                    k++;
                }
            }

            int size_results = 1;
            while (size_results<= sellerCoinsCnt)
            {
                int[] list = new int[listCoins.Length];
                recRest(size_results, list, 0);
                size_results++;
            }
            
            return result;
        }
    }
}
