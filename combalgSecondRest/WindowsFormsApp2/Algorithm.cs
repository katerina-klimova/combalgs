using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Algorithm
    {
        public static int countOfWays(int[] coins, int[] counts, int idx,  int sum)
        {
            if (sum == 0)
                return 1;

            if (sum < 0)
                return 0;

            if (idx <= 0 && sum >= 1)
                return 0;

            int include = 0;
            if (counts[idx - 1] > 0)
            {
                counts[idx - 1]--;
                include = countOfWays(coins, counts, idx, sum - coins[idx - 1]);
                counts[idx - 1]++;
            }
            int exclude = countOfWays(coins, counts, idx - 1, sum);

            return include + exclude;
        }
    }
}
