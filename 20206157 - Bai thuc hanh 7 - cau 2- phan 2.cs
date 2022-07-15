/* Nguyễn Quang Minh 20206157
Hãy khai báo cấu trúc dữ liệu cho danh sách liên kết đơn: MSSV, họ và tên, học phần, điểm*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_2_2
{
    public class SV
    {
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string HP { get; set; }
        public double Diem { get; set; }
        public SV(string mssv = "", string name = "", string hp = "", double diem = 0)
        {
            this.MSSV = mssv;
            this.Name = name;
            this.HP = hp;
            this.Diem = diem;
        }
        public override string ToString()
        {
            return "MSSV: " + MSSV + " | Họ tên: " + Name + " | Học Phần: " + HP + " | Điểm: " + Diem;
        }
    }
    public class LinkerListNode
    {
        public SV data;
        public LinkerListNode next;

        public LinkerListNode(SV inf)
        {
            data = inf;
            next = null;
        }
    }
    public class LinkedList
    {
        LinkerListNode head;

        public LinkedList()
        {
            head = null;
        }
        public void AddHead(SV data)
        {
            LinkerListNode newNode = new LinkerListNode(data);
            newNode.next = head;
            head = newNode;
        }
        public void PrintList()
        {
            LinkerListNode curNode = head;
            while (curNode != null)
            {
                Console.WriteLine(curNode.data.ToString());
                curNode = curNode.next;
            }
        }
    }

    public class Bai7_2_2
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            LinkedList linkedList = new LinkedList();
            linkedList.AddHead(new SV("20206112", "Nguyễn Đức Anh", " Giải tích hàm ", 10));
            linkedList.AddHead(new SV("20206157", " Nguyễn Quang Minh  ", "  Toán rời rạc  ", 8.5));
            linkedList.AddHead(new SV("20206210", "  Nguyễn Văn Quốc   ", "  Giải tích 2   ", 9.5));
            linkedList.AddHead(new SV("20206156", "   Hoàng Đức Mạnh   ", "  Giải tích số  ", 10));
            linkedList.PrintList();
        }
    }
}
