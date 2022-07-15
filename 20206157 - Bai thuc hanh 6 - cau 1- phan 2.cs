/*  Nguyễn Quang Minh - 20206157
 Thực hành đệ quy qua cài đặt các bài toán sau (1 bài nào đó)​
Bài toán n hậu
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_thực_hành_số_6
{
    class Bài_1_2
    {
        static int[] board;
        static int size;
        static int numSolutions = 0;

        public static void placeQueen(int column)
        {
            if (column == size)
            {
                numSolutions++;
                for (int index = 0; index < size; index++)
                {
                    Console.Write((board[index] + 1) + "\t");
                }
                Console.WriteLine();
            }

            for (int row = 0; row < size; row++)
            {
                if (noCollisions(column, row))
                {
                    board[column] = row;
                    placeQueen(column + 1);
                }
            }
        }

        public static bool noCollisions(int col, int row)
        {
            for (int prevCol = 0; prevCol < col; prevCol++)
            {
                if (row == board[prevCol] || col - row == prevCol - board[prevCol] || col + row == prevCol + board[prevCol])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Main()
        {
            Console.Write("Enter the number of rows/ columns: ");
            size = Int32.Parse(Console.ReadLine());
            board = new int[size];

            Console.WriteLine("Column");
            for (int i = 0; i < size; i++)
            {
                Console.Write((i + 1) + "\t");
                Console.WriteLine();
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write("----------\t");
                Console.WriteLine();
            }

            placeQueen(0);

            Console.Write("Total numbers of solutions: ");
            Console.WriteLine(numSolutions);
        }
    }
}
