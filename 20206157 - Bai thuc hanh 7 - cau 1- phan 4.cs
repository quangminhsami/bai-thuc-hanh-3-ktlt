/* Nguyễn Quang Minh 20206157
 Đề bài: Tìm dãy con toàn dương có tổng lớn nhất*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_thực_hành_số_7
{
    class Bài_7_1_4
    {
		public static void printArray(int[] arr, int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.Write("{0}\t", arr[i]);
			}
		}

        public static void findSubArrayMax(int[] arr, int n)
        {
            int best = 0, sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = Math.Max(arr[i], sum + arr[i]);
                best = Math.Max(best, sum);
                if (sum < 0)
                {
                    sum = 0;
                }
            }
            Console.WriteLine("\n{0}",best);
        }

        public static void findSubArrayMaxWithIndices(int[] arr, int n)
        {
            int best = 0, sum = 0;
            int best_start = 0, best_end = 0, current_start = 0;
            for (int i = 0; i < n; i++)
            {
                if (sum + arr[i] < arr[i])
                {
                    current_start = i;
                    sum = arr[i];
                }
                else
                {
                    sum += arr[i];
                }

                if (best < sum)
                {
                    best = sum;
                    best_start = current_start;
                    best_end = i;
                }
            }
            Console.WriteLine("Start from {0} to {1}", best_start, best_end);
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mảng ban đầu :");
            int[] arr = { -1, 2, 5, 10, 5, -7 };
            int n = arr.Length;
            printArray(arr, n);
            findSubArrayMax(arr, n);
            findSubArrayMaxWithIndices(arr, n);

        }
    }
}
