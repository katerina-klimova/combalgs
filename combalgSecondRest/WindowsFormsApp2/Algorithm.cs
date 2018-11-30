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
        int result;

        public Algorithm(int[] _listCoins, int _rest, int[] _cashBox)
        {
            listCoins = _listCoins;
            rest = _rest;
            cashBox = _cashBox;
            result = 0;
        }

        private int countVariants(int _rest, int lev)
        {
            int result;
            int tmp = 0;
            if ((_rest < 0) || (lev >= 7))
            {
                if (_rest == 0)
                {
                      tmp = 1;
                }

            }
            else
            {
                if (cashBox[lev] == 0)
                    tmp = countVariants(_rest, lev + 1);
                else
                    for (int i = 0; i <= cashBox[lev]; i++)
                    {

                        int newRest = _rest - listCoins[lev] * i;
                        tmp = tmp + countVariants(newRest, lev + 1);
                    }
            }
            return result = tmp;
        }
        public int restCoins()
        {
            int sellerCoinsCnt = 0;
            for (int j = 0; j < cashBox.Length; j++)
            {
                sellerCoinsCnt += cashBox[j];
            }
            if (sellerCoinsCnt != 0) 
            {
                result = countVariants(rest,0);
            }

            return result;
        }
    }
}
