using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdCombSubSet
{
    class Chromosome
    {
        Random r ;
        private int[] code;
        int k;
        int size;
        public Chromosome(int[] items, Random _r)
        {
            r = _r;
            code = new int[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                code[i] = r.Next(2);
            }
            setK(items);
            size = code.Length;
        }
        

        public Chromosome(Chromosome f, Chromosome m, Random _r)
        {
            r = _r;
            int a, b;
            do
            {
                a = r.Next(0, f.size);
                b = r.Next(0, f.size);

            } while (a == b);
            if(a>b)
            {
                int c = a;
                a = b;
                b = c;
            }
           
            code = new int[f.size];
            for (int i = 0; i < a; i++)
            {
                code[i] =f.get(i) ;
            }
            for (int i = a; i <b; i ++)
            {
                code[i] =  m.get(i);
            }
            for (int i =b; i < size; i ++)
            {
                code[i] = f.get(i);
            }

        }

        /*Вычисление коэффициента выживаемости (fitness)*/
        public void setK(int[] items)
        {
            k = 0;
            for (int i = 0; i < code.Length; i++)
            {
                k += items[i]*code[i];
            }
            k = Math.Abs(k);
        }

        public int getK()
        {
            return k;
        }

        public int get(int i)
        {
            return code[i];
        }

        public  bool checkChromosome(int[] items)
        {
            if ( code.Length > 0)
            {
                int sum = items[0] * code[0];

                for (int i = 1; i < code.Length; i++)
                {
                    sum += items[i] * code[i];
                }
                return sum == 0;
            }
            return false;
        }

        public void setChromosome(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                code[i] = r.Next(2);
            }
        }

        public int[] toArray(int[] items)
        {
            int len=0;
            for(int i = 0; i < code.Length; i++) { len += code[i]; }
            int[] arr = new int[len];
            int j = 0;
            for(int i = 0; i < code.Length; i++) {
                if (code[i] == 1) {
                    arr[j] = code[i]*items[i];
                    j++;
                }
            }
            return arr;
        }

        public bool isEmpty()
        {
            foreach (int el in code)
                if (el > 0) return false;
            return true;
        }

        public void mutate(int percent)
        {
            if(r.Next(1,100)<=percent)
            {
                int num = r.Next(0, code.Length);
               if( code[num] == 1)  { code[num] = 0; } else { code[num] = 1; }
            }
        }

        
    }
}
