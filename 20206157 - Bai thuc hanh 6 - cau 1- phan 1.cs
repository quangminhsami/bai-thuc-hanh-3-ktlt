/*  Nguyễn Quang Minh - 20206157
Đề bài: Thực hành đệ quy qua cài đặt các bài toán sau (1 bài nào đó)​

Tính số Fibonaci F(n)   */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_thực_hành_số_6
{
    class Bài_1_1
    {
        static int fibo(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            else
            {
                return fibo(n - 1) + fibo(n - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Số fibonacci thứ {0} là {1}", n, fibo(n));      
        }
    }
}
