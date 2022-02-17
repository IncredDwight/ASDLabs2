using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperations
{
    class ArrayHelper
    {
        public static int[] GenerateRandom(int length, int minValue, int maxValue)
        {
            Random rand = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(minValue, maxValue);
            }

            return array;
        }

        public static int[] GenerateRandom(int length)
        {
            Random rand = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(-length, length);
            }

            return array;
        }

        public static int[] GenerateSequence(int minValue, int maxValue)
        {
            int[] array = new int[maxValue - minValue + 1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = minValue + i;
            }

            return array;
        }

        public static int[] GenerateReversedSequence(int minValue, int maxValue)
        {
            int[] array = new int[maxValue - minValue + 1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = maxValue - i;
            }

            return array;
        }

        public static void Display(int[] array, string caption = "Array: ")
        {
            Console.WriteLine("\n" + caption);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
