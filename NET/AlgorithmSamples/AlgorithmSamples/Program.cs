using System;

namespace AlgorithmSamples
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            //FirstRepeatedItem.MainA(args);
            largestDifference(new int[]{28, 16, 28, 11, 14, 26, 23, 25, 17, 3, 22, 23, 23, 10});
            Console.ReadKey();
        }

        public static int largestDifference(int[] data)
        {
            int minElement = data[0], maxDifference = 0;

            for (int i = 1; i < data.Length; i++)
            {
                minElement = Math.Min(minElement, data[i]);
                maxDifference = Math.Max(maxDifference, data[i] - minElement);
            }
            return maxDifference;
        }
    }
}
