using System;
namespace AlgorithmSamples
{
    public class ConsecutiveNumbersInArray
    {
        static bool areConsecutive(int[] arr, int n)
        {
            if (n < 1)
                return false;

            /* 1) Get the minimum element in
            array */
            int min = getMin(arr, n);

            /* 2) Get the maximum element in
            array */
            int max = getMax(arr, n);

            /* 3) max-min+1 is equal to n then
            only check all elements */
            if (max - min + 1 == n)
            {
                int i;
                for (i = 0; i < n; i++)
                {
                    int j;

                    if (arr[i] < 0)
                        j = -arr[i] - min;
                    else
                        j = arr[i] - min;

                    // NOTE:
                    // if 'j' is out of range of array then consecutive is false(my guess)
                    

                    // if the value at index j
                    // is negative then
                    // there is repetition
                    if (arr[j] > 0)
                        arr[j] = -arr[j];
                    else
                        return false;
                }

                /* If we do not see a negative
                value then all elements
                are distinct */
                return true;
            }

            // if (max-min+1 != n)
            return false;
        }

        /* UTILITY FUNCTIONS */
        static int getMin(int[] arr, int n)
        {
            int min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        static int getMax(int[] arr, int n)
        {
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        /* Driver program to test above
        functions */
        public static void MainA()
        {
            int[] arr = { 5, 4, 2, 3, 1, 6 };
            int n = arr.Length;

            if (areConsecutive(arr, n) == true)
                Console.Write("Array elements "
                          + "are consecutive");
            else
                Console.Write("Array elements "
                      + "are not consecutive");
        }
    }
}
