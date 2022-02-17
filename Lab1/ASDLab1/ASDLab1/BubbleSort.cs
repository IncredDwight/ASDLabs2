using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace SortingAlgorithms
{
    class BubbleSort
    {
        protected string name;

        protected long executionTime;
        protected int swapAmount;
        protected int comparison;

        public BubbleSort(string name1)
        {
            name = name1;
        }

        public void TimeSort(int[] array)
        {
            Stopwatch watch = Stopwatch.StartNew();
            Sort(array);
            watch.Stop();
            executionTime = watch.ElapsedMilliseconds;
        }

        public virtual void Sort(int[] array)
        {
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length - i; j++)
                {
                    comparison++;
                    if (array[j - 1] > array[j])
                    {
                        Swap(array, j - 1, j);
                        swapAmount++;
                    }
                }
            }
            watch.Stop();
            executionTime = watch.ElapsedMilliseconds;
        }

        public void DisplaySortResult()
        {
            Console.WriteLine("\n" + name + " result");
            Console.WriteLine("Execution time: " + executionTime + "ms");
            Console.WriteLine("Execution swap amount: " + swapAmount);
            Console.WriteLine("Execution comparsion amount: " + comparison + "\n");
        }

        protected void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }

    class CombSort : BubbleSort
    {
        public CombSort(string name1) : base(name1)
        {
            
        }

        public override void Sort(int[] array)
        {
            Stopwatch watch = Stopwatch.StartNew();

            int gap = array.Length;

            while (gap > 1)
            {
                gap = (int)(gap / 1.3);
                if (gap < 1)
                    gap = 1;

                for (int i = 0; i < array.Length - gap; i++)
                {
                    comparison++;
                    if (array[i] > array[i + gap])
                    {
                        Swap(array, i, i + gap);
                        swapAmount++;
                    }
                }
            }

            watch.Stop();
            executionTime = watch.ElapsedMilliseconds;
        }
    }
}
