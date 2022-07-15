/*  Nguyễn Quang Minh - 20206157
 Thực hành đệ quy qua cài đặt các bài toán sau (1 bài nào đó)​
Bài toán tháp Hà Nội
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_thực_hành_số_6
{
    class Bài_1_3
    {
        static void Tower(int n, char a, char b, char c)
        {
            if (n == 1)
            {
                Console.WriteLine("\t");
                Console.Write(a);
                Console.Write("------------");
                Console.Write(c);
                return;
            }
            Tower(n - 1, a, c, b);
            Tower(1, a, b, c);
            Tower(n - 1, b, a, c);
        }

        static void Main(string[] args)
        {
            char a = 'A', b = 'B', c = 'C';
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Tower(n, a, b, c);
        }
    }
}
