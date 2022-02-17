using System;
using SortingAlgorithms;
using ArrayOperations;

namespace ASDLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort("Bubble sort");
            CombSort combSort = new CombSort("Comb sort");

            int[] array = ArrayHelper.GenerateReversedSequence(1, 50000);
            ArrayHelper.Display(array);
            combSort.Sort(array);
            ArrayHelper.Display(array, "Sorted: ");
            combSort.DisplaySortResult();
        }
    }
}
