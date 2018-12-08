using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdCombSubSet
{
    class Algorithm
    {
        bool detected = false;
        int[] answer;
        public  int[] exact(int[] set)
        {
            int[] result = new int[set.Length];
            rec(set, result, 0, 0);
            return answer;
        }

        public bool rec(int [] set, int[] result, int k,int sum)
        {
            for(int i = k; (i < set.Length)&&!detected;i++)
            {
                result[k] = set[i];
                if (sum + result[k] == 0)
                {
                    answer = new int[k + 1];
                    Array.Copy(result, answer,k+1);
                   return true;
                }
                else
                {
                    detected = rec(set, result, k+1, sum + result[i]);
                    result[i] = 0;
                }
                   
            }
            return detected;
        }
    }
}
