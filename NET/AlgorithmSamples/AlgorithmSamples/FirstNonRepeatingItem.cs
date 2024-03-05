using System;
using System.Collections.Generic;

namespace AlgorithmSamples
{
    public class FirstNonRepeatingItem    
    {

        static void firstNonRepeating(int[] arr, int n)
        {
            // Insert all array elements in hash table
            Dictionary<int, int> m = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (m.ContainsKey(arr[i]))
                {
                   m[arr[i]] += 1;
                }
                else
                {
                    m.Add(arr[i], 1);
                }
            }

            // Traverse through map only and
            // using for-each loop for iteration over Map.entrySet()
            foreach (KeyValuePair<int, int> x in m)
            {
                if (x.Value == 1)               
                    Console.Write(x.Key + " ");
            }
        }
        // Driver code
        public static void MainA(String[] args)
        {
            int[] arr = { 5, 5, 3, 9, 4, 9, 6, 7, 4 };
            int n = arr.Length;
            firstNonRepeating(arr, n);
        }
    }
}
