/* Nguyễn Quang Minh 20206157
Đề bài: Thuật toán trên cấu trúc dữ liệu ngăn xếp​
Xây dựng được chương trình soạn thảo có undo và redo*/

using System;
using System.Collections;

class Bài1_1
{
	static Stack Undo = new Stack();
	static Stack Redo = new Stack();

	static void WRITE(Stack Undo, char X)
	{
		Undo.Push(X);
	}

	static void UNDO(Stack Undo, Stack Redo)
	{
		char X = (char)Undo.Peek();
		Undo.Pop();
		Redo.Push(X);
	}

	static void REDO(Stack Undo, Stack Redo)
	{
		char X = (char)Redo.Peek();
		Redo.Pop();
		Undo.Push(X);
	}

	static void READ(Stack Undo)
	{
		Stack revOrder = new Stack();

		while (Undo.Count > 0)
		{
			revOrder.Push(Undo.Peek());
			Undo.Pop();
		}

		while (revOrder.Count > 0)
		{
			Console.Write(revOrder.Peek());
			Undo.Push(revOrder.Peek());
			revOrder.Pop();
		}

		Console.Write(" ");
	}
	static void QUERY(string[] Q)
	{
		int N = Q.Length;

		for (int i = 0; i < N; i++)
		{
			if (Q[i] == "UNDO")
			{
				UNDO(Undo, Redo);
			}
			else if (Q[i] == "REDO")
			{
				REDO(Undo, Redo);
			}
			else if (Q[i] == "READ")
			{
				READ(Undo);
			}
			else
			{
				WRITE(Undo, Q[i][6]);
			}
		}
	}

	static void Main()
	{
		string[] Q = { "WRITE A", "WRITE B", "WRITE C", "UNDO", "READ", "REDO", "READ" };
		QUERY(Q);
	}
}

