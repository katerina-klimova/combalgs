using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace thirdCombSubSet
{
    class GeneticAlgorithm
    {
        Logger logger;
        private Random r;
        private Stopwatch stopWatch;
        private long curTimeGen;

        private int numOfChromosomes;
        private int[] items;
        private int mutationPercent;
        private int mutationCount;
        private int cntParentChromes;

        bool detected = false;
        int[] answer;
        
        List<Chromosome> firstGeneraion;
        List<Chromosome> currentGeneraion;
        
        public long getWorkTime()
        {
            return curTimeGen;
        }

        public GeneticAlgorithm(int _numOfChrom, int[] _items, int _mutPercent, int _mutCnt, int _cntParentChromes)
        {
            r = new Random();
            numOfChromosomes = _numOfChrom;
            items = _items;
            mutationPercent = _mutPercent;
            mutationCount = _mutCnt;
            cntParentChromes = _cntParentChromes;
            logger = new Logger("log.txt");
        }

        public int[] run(int steps)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
            logger.log("Запуск алгоритма!");
            setFirstGeneration();
            logger.log("Первое поколение: \n" + toString(firstGeneraion));
            if (checkAll(firstGeneraion)) {
                detected = true;
               // return answer;
            }
            
            sortPopulation(firstGeneraion);
            currentGeneraion = firstGeneraion;
            int step = 2;
            while (!detected && (step <= steps)) 
            {
                /*Cледующее поколение.*/
                getNextGeneration(currentGeneraion,step);
                logger.log("Поколение:"+ step +"после мутации \n" + toString(currentGeneraion)+Environment.NewLine);
                if (checkAll(currentGeneraion)) detected = true;
                sortPopulation(firstGeneraion);
                step++;

            } 
          
            stopWatch.Stop();
            curTimeGen = stopWatch.ElapsedTicks;
            logger.close();
            return answer;
        }

        private bool checkAll(List<Chromosome> generaion)
        {
            for(int i=0; (i<firstGeneraion.Count)&& !detected;i++)
            {
                if (generaion[i].getK() == 0)
                {
                    answer = generaion[i].toArray(items);
                    detected = true;
                }
            }
            return detected;
        }
        
        /*Генерация случайного начального состояния.*/
        private void setFirstGeneration()
        {
            firstGeneraion = new List<Chromosome>();
            for(int j = 0; firstGeneraion.Count < numOfChromosomes;)
            {
                Chromosome ch = new Chromosome(items, r);
                if (!ch.isEmpty())
                {
                    firstGeneraion.Add(ch);
                    j++;
                }
            }
        }

        private void getNextGeneration(List<Chromosome> curGen, int step)
        {
            List<Chromosome> newGeneration = new List<Chromosome>();
            double p = 0;
            double[] ver = new double[curGen.Count];
            foreach(Chromosome ch in curGen)
            {
                p += ch.getK();
            }
            ver[0] = (1 - ( (double)curGen[0].getK() / p) )/(ver.Length - 1);
            for (int i =1; i < ver.Length; i++)
            {
                ver[i] =ver[i-1] + (1 - ( (double)curGen[i].getK() /p) )/(ver.Length-1);
            }

            /*Воспроизводство.*/
            for (int i = 0; i <cntParentChromes; i++)
            {
                newGeneration.Add(curGen[choosed(ver)]);
            }
            for(int i = (cntParentChromes) ; (i < numOfChromosomes-1) && newGeneration.Count<curGen.Count; i++)
            {
                Chromosome newChild_1 = selection(newGeneration[i-(numOfChromosomes / 2)], newGeneration[i - (numOfChromosomes / 2)+1]);
                Chromosome newChild_2 = selection(newGeneration[i - (numOfChromosomes / 2)+1], newGeneration[i - (numOfChromosomes / 2) ]);
                if(!newChild_1.isEmpty()) newGeneration.Add(newChild_1);
                if (newGeneration.Count < curGen.Count && !newChild_2.isEmpty()) newGeneration.Add(newChild_2);
            }
            logger.log("Поколение:" + step + "до мутации \n" + toString(currentGeneraion));
            mutation(newGeneration);
            curGen = newGeneration;
        }

        private void mutation(List<Chromosome> generation)
        {
            
            for(int i = 0; i < mutationCount; i++)
            {
                int num = r.Next(0, generation.Count);
                generation[num].mutate(mutationPercent);
                generation[num].setK(items);
            }
        }

        private int choosed(double[] ver)
        {
            double curVer = r.NextDouble();
            for(int i = 0; i < ver.Length; i++)
            {
                if(curVer<ver[i])
                    return i;
            }
            return ver.Length-1;
        }

        public void sortPopulation(List<Chromosome> popullation)
        {
            int k;
            Chromosome x;
            for (int i = 0; i < popullation.Count; i++)
            {   // i - номер текущего шага
                k = i;
                x = popullation[i];
                for (int j = i + 1; j < popullation.Count; j++)  // цикл выбора наименьшего элемента
                    if (popullation[j].getK() < x.getK())
                    {
                        k = j;
                        x = popullation[j];            // k - индекс наименьшего элемента
                    }

                popullation[k] = popullation[i];
                popullation[i] = x;      // меняем местами наименьший с popullation[i]
            }
        }

        private Chromosome selection(Chromosome father, Chromosome mother)
        {
            Chromosome child = new Chromosome(father, mother,r);
            child.setK(items);
            return child;
        }

        public string toString(List<Chromosome> chs)
        {
            string s = "";
            foreach(Chromosome ch in chs)
            {
                int[] arr = ch.toArray(items);
                s += "   { ";
                for(int i = 0; i < arr.Length ;i++)
                {
                    s += arr[i] + " ";
                }

                s += " }   ";
            }
            return s;
        }
    }
}
