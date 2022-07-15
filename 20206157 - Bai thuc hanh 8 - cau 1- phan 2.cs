/* Nguyễn Quang Minh 20206157
Đề bài: Xây dựng chương trình tính được giá trị của một biểu thức toán học*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_thực_hành_số_8
{
	public class EvaluateString
	{
		public static int evaluate(string expression)
		{
			char[] tokens = expression.ToCharArray();

			Stack<int> values = new Stack<int>();

			Stack<char> ops = new Stack<char>();

			for (int i = 0; i < tokens.Length; i++)
			{
				if (tokens[i] == ' ')
				{
					continue;
				}

				if (tokens[i] >= '0' && tokens[i] <= '9')
				{
					StringBuilder sbuf = new StringBuilder();

					while (i < tokens.Length && tokens[i] >= '0' && tokens[i] <= '9')
					{
						sbuf.Append(tokens[i++]);
					}
					values.Push(int.Parse(sbuf.ToString()));

					i--;
				}

				else if (tokens[i] == '(')
				{
					ops.Push(tokens[i]);
				}

				else if (tokens[i] == ')')
				{
					while (ops.Peek() != '(')
					{
						values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
					}
					ops.Pop();
				}

				else if (tokens[i] == '+' || tokens[i] == '-' || tokens[i] == '*' || tokens[i] == '/')
				{
					while (ops.Count > 0 && hasPrecedence(tokens[i], ops.Peek()))
					{
						values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
					}

					ops.Push(tokens[i]);
				}
			}

			while (ops.Count > 0)
			{
				values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
			}

			return values.Pop();
		}

		public static bool hasPrecedence(char op1, char op2)
		{
			if (op2 == '(' || op2 == ')')
			{
				return false;
			}
			if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public static int applyOp(char op, int b, int a)
		{
			switch (op)
			{
				case '+':
					return a + b;
				case '-':
					return a - b;
				case '*':
					return a * b;
				case '/':
					if (b == 0)
					{
						throw new
						System.NotSupportedException("Cannot divide by zero");
					}
					return a / b;
			}
			return 0;
		}

		public static void Main(string[] args)
		{
			Console.WriteLine(EvaluateString.evaluate("5 + 2 * 4"));
			Console.WriteLine(EvaluateString.evaluate("10 * 6 - 15"));
			Console.WriteLine(EvaluateString.evaluate("10 * ( 2 + 4 )"));
			Console.WriteLine(EvaluateString.evaluate("10 * ( 2 + 7 ) / 9"));
		}
	}
}