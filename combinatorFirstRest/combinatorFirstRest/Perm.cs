using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combinatorFirstRest
{
    class Perm
    {
        public static void swap(ref int[] perm, int i, int j)
        {
            int tmp = perm[i];
            perm[i] = perm[j];
            perm[j] = tmp;
        }

        public static int[] getFirstPerm(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

        public static Boolean getNextPerm(ref int[] perm)
        {
            int n = perm.Length ;
            int i = n - 1;
            for (; i > 0 && perm[i] < perm[i - 1]; i--) ;
            if (i == 0)
                return false;
            int j = n - 1;
            for (; j >= 0 && perm[j] < perm[i - 1]; j--) ;
            swap(ref perm, i - 1, j);
            for (int k = 0; k <= (n - i) / 2 - 1; k++)
            {
                swap(ref perm, k + i, n - k - 1);
            }
            return true;
        }
    
      
    }
}
