/* Nguyễn Quang Minh - 20206157
 * Thuật toán trên cấu trúc dữ liệu danh sách​
Thêm, sửa, xóa, tìm kiểm một phần tử trong danh sách*/
using System;
using System.Collections.Generic;

namespace Bài_thực_hành_số_7
{
    class Bài_7_2_1
    {
        public static void Main(string[] args)
        {
            // tạo danh sách rỗng
            List<int> new_List = new List<int>();

            // Thêm phần tử trong danh sách
            new_List.Add(1);
            new_List.Add(2);
            new_List.Add(3);
            new_List.Add(4);
            new_List.Add(5);
            foreach(int k in new_List)
            {
                Console.Write("{0}\t", k);
            }

            // Xóa phần tử trong danh sách
            new_List.Remove(3);
            Console.WriteLine();
            foreach (int k in new_List)
            {
                Console.Write("{0}\t", k);
            }

            // Sửa phần tử trong danh sách
            Console.WriteLine();
            new_List[2] = 6;
            for (int i = 0; i < new_List.Count(); i++)
            {
                Console.Write("{0}\t", new_List[i]);
            }

            // Tìm kiếm 1 phần tử trong danh sách
            Console.WriteLine();
            for (int i = 0; i < new_List.Count(); i++)
            {
                if (new_List[i] == 6)
                {
                    Console.WriteLine("Find!");
                    break;
                }
            }
        }
    }
}
