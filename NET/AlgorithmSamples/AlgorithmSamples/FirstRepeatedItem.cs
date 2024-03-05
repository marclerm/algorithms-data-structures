
using System;
using System.Collections.Generic;

/* C# program to find first repeating element in arr[] */

public class FirstRepeatedItem
{
	// This function prints the first repeating element in arr[]
	public static void printFirstRepeating(int[] arr)
	{
		// Initialize index of first repeating element
		int min = -1;
		// Creates an empty hashset
		HashSet<int> set = new HashSet<int>();
		// Traverse the input array from right to left
		for (int i = arr.Length - 1; i >= 0; i--)
		{
			// If element is already in hash set, update min
			if (set.Contains(arr[i]))
			{
				min = i;
			}
			else // Else add element to hash set
			{
				set.Add(arr[i]);
			}
		}
		// Print the result
		if (min != -1)
		{
			Console.WriteLine("The first repeating element is " + arr[min]);
		}
		else
		{
			Console.WriteLine("There are no repeating elements");
		}

        Math.Abs(-10);
    }

	// Driver method to test above method

	public static void MainA(string[] args)
	{
		int[] arr = new int[] { 7,10, 5, 3, 6, 4, 3, 5, 6 };
		printFirstRepeating(arr);
	}
}

// This code is contributed by Shrikant13
