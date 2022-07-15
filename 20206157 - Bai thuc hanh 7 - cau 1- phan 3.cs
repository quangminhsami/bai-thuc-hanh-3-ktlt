/* Nguyễn Quang Minh 20206157
 Đề bài: Cho mảng a, số nguyên M. Tìm 1 mảng con sao cho tổng các phần tử bằng M */

using System;

class Bài_7_1_3
{
	public static void printArray(int[] arr, int n)
	{
		for (int i = 0; i < n; i++)
		{
			Console.Write("{0}\t", arr[i]);
		}
	}

	int subArraySum(int[] arr, int n, int sum)
	{
		int curr_sum, i, j;

		for (i = 0; i < n; i++)
		{
			curr_sum = arr[i];

			for (j = i + 1; j <= n; j++)
			{
				if (curr_sum == sum)
				{
					int p = j - 1;
					Console.Write("\nSum found between " + "indexes " + i + " and " + p);
					return 1;
				}
				if (curr_sum > sum || j == n)
					break;
				curr_sum = curr_sum + arr[j];
			}
		}

		Console.Write("No subarray found");
		return 0;
	}

	public static void Main()
	{
		Sub_Array arraysum = new Sub_Array();
		int[] arr = { 1, 2, 4, 8, 9, 5, 14, -7 };
		int n = arr.Length;
		printArray(arr, n);
		int sum = int.Parse(Console.ReadLine());
		arraysum.subArraySum(arr, n, sum);
	}
}

