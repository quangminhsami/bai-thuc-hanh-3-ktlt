/* Nguyễn Quang Minh 20206157
 Đề bài:​ Tính khoảng cách trung bình giữa các giá trị trong mảng*/
using System;
using System.Text;

namespace Bài_thực_hành_số_7
{
    class Bài_7_1_1
    {
        public static void printArray(int[] arr, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("{0}\t",arr[i]);
            }
        } 

        public static double distance_average(int[] arr, int n)
        {
            double sum_distance = 0;
            for(int i = 1; i < n; i++)
            {
                sum_distance += Math.Abs(arr[i] - arr[i - 1]);
            }
            return (sum_distance) / (n - 1);
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mảng ban đầu :");
            int[] arr = { -1, 2, -9, 5, 7 };
            int n = arr.Length;
            printArray(arr,n);
            Console.WriteLine("\nKhoảng cách trung bình giữa các giá trị trong mảng là {0}", distance_average(arr, 5));
        }
    }
}
