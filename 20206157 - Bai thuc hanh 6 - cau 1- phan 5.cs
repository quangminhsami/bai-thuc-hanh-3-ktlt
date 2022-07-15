/*  Nguyễn Quang Minh - 20206157
 Thực hành đệ quy qua cài đặt các bài toán sau (1 bài nào đó)​
Bài toán liệt kê hoán vị
*/
using System;

class Bai1_5
	{
		private static void permute(String str, int l, int r)
		{
			if (l == r)
				Console.WriteLine(str);
			else
			{
				for (int i = l; i <= r; i++)
				{
					str = swap(str, l, i);
					permute(str, l + 1, r);
					str = swap(str, l, i);
				}
			}
		}

		public static String swap(String a, int i, int j)
		{
			char temp;
			char[] charArray = a.ToCharArray();
			temp = charArray[i];
			charArray[i] = charArray[j];
			charArray[j] = temp;
			string s = new string(charArray);
			return s;
		}

		public static void Main()
		{
			String str = "ABCD";
			int n = str.Length;
			permute(str, 0, n - 1);
		}
	}
