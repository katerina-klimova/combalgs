using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combinatorFirstRest
{
    class Algorithm
    {
        private int[] listCoins;
        int rest =0 ;
        int[] cashBox;
        int currentCnt = 0;
        int[] currentCombination;
        int[] data;
        public Algorithm(int[] _listCoins, int _rest, int [] _cashBox)
        {
            listCoins = _listCoins;
            rest = _rest;
            cashBox = _cashBox;
        }


        /*private int[] recRest(int k, int[] coins, int curSum)
        {

            if (Math.Abs(curSum - rest) < 0.001)
            {
                found = true;
                return coins;
            }
            if (k > 0)
            {
                for (int i = 0; (i < listCoins.Length) && (!found); i++)
                {
                    coins[i]++;
                    recRest(k - 1, coins, curSum + listCoins[i]);
                    if (!found)
                        coins[i]--;
                }
            }

            return coins;
        }*/
        
        private int check(int[] comb,int restCoins)
        {
            for(int i = 0; (i < comb.Length)&&(restCoins>0); i++)
            {
                restCoins -= data[comb[i]];
                if (restCoins ==0) return i+1;
            }
            return -1;
        }

        private void calculateCombinations( int[] combination)
        {
            
            do
            {
                int k = check(combination, rest);
                if ((k > 0) && (k < currentCnt))
                {
                    currentCnt = k;
                    currentCombination = new int[combination.Length];
                    for (int j = 0; j < combination.Length; j++)
                    {
                        currentCombination[j] = combination[j];
                    }
                }
                
            } while (Perm.getNextPerm(ref combination)) ;
        }

        /*Сколько монет каждого номинала надо отдать*/
        public int[] restCoins()
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
            k = 0;
            currentCnt = sellerCoinsCnt;
            int[] firstCombination = Perm.getFirstPerm(sellerCoinsCnt);
            
            calculateCombinations( firstCombination);
            int[] result = new int[data.Length];
            for(int l = 0; l < data.Length; l++)
            {
                result[l] = data[currentCombination[l]];
            }

            return result;

            
            /*int[] result = new int[8];

            int i = 0;

            while (!found || (i<sellerCoinsCnt))
            {
                result = recRest(++i, result, 0);
            }  
            if (!found)
            {
                throw new Exception();
            }*/
        }
        
    }
}
