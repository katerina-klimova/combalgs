﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace thirdCombSubSet
{
    class ExactAlgorithm
    {
        bool detected = false;
        int[] answer;
        private Stopwatch stopWatch ;
        private long curTimeEx;
        public long getWorkTime()
        {
            return curTimeEx;
        }

        public  int[] run(int[] set)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
            int[] result = new int[set.Length];
            HashSet<int> indexes = new HashSet<int>();
            rec(set, 0, 0, indexes);
            stopWatch.Stop();
            curTimeEx = stopWatch.ElapsedTicks;
            return answer;
        }
        
        private bool rec(int[] set,  int k, int sum, HashSet<int> indexes)
        {
            for (int i = 0; (i < set.Length) && !detected && (k < set.Length); i++)
            {
                if (!indexes.Contains(i))
                {
                    indexes.Add(i);
                    if (sum + set[i] == 0)
                    {
                        int j = 0;
                        answer = new int[k + 1];
                        foreach(int el in indexes){
                            answer[j] = set[el];
                            j++;
                        }
                        return true;
                    }
                    else
                    {
                        detected = rec(set, k + 1, sum +set[i], indexes);
                        indexes.Remove(i);
                    }
                }
            }
            return detected;
        }
        
    }
}
