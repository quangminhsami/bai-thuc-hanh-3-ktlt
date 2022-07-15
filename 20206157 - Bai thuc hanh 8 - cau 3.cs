/* Nguyễn Quang Minh 20206157
Xây dựng chương trình mô phỏng một cây nhị phân tìm kiếm với các thao tác: 
thêm, xóa, kiểm tra một phần tử, đếm số phần tử của cây*/

using System;
class BinarySearchTree
{
	public class Node
	{
		public int key;
		public Node left, right;

		public Node(int item)
		{
			key = item;
			left = right = null;
		}
	}

	Node root;

	BinarySearchTree() { root = null; }

	BinarySearchTree(int value) { root = new Node(value); }

	void insert(int key) { root = insertRec(root, key); }

	Node insertRec(Node root, int key)
	{
		if (root == null)
		{
			root = new Node(key);
			return root;
		}

		if (key < root.key)
			root.left = insertRec(root.left, key);
		else if (key > root.key)
			root.right = insertRec(root.right, key);

		return root;
	}

	void deleteKey(int key) { root = deleteRec(root, key); }

	Node deleteRec(Node root, int key)
	{
		if (root == null)
			return root;

		if (key < root.key)
			root.left = deleteRec(root.left, key);
		else if (key > root.key)
			root.right = deleteRec(root.right, key);
		else
		{
			if (root.left == null)
				return root.right;
			else if (root.right == null)
				return root.left;

			root.key = minValue(root.right);

			root.right = deleteRec(root.right, root.key);
		}
		return root;
	}

	int minValue(Node root)
	{
		int minv = root.key;
		while (root.left != null)
		{
			minv = root.left.key;
			root = root.left;
		}
		return minv;
	}

	public Node search(Node root, int key)
	{
		if (root == null || root.key == key)
			return root;

		if (root.key < key)
			return search(root.right, key);

		return search(root.left, key);
	}

	void searchKey(int key) { search(root, key); }
	void count() { Console.Write(countNodes(root)); }

	public static int countNodes(Node root)
    {
		if (root == null) return 0;
        else
        {
			return countNodes(root.right) + countNodes(root.left) + 1;
        }
    }

	void inorder() { inorderRec(root); }

	void inorderRec(Node root)
	{
		if (root != null)
		{
			inorderRec(root.left);
			Console.WriteLine(root.key);
			inorderRec(root.right);
		}
	}

	public static void Main(String[] args)
	{
		BinarySearchTree tree = new BinarySearchTree();

		tree.insert(50);
		tree.insert(30);
		tree.insert(20);
		tree.insert(40);
		tree.insert(70);
		tree.insert(60);
		tree.insert(80);

		Console.WriteLine("Travesal inorder: ");
		tree.inorder();

		Console.WriteLine("==========================================");
		tree.insert(90);
		Console.WriteLine("After insert: ");
		tree.inorder();

		Console.WriteLine("==========================================");
		tree.deleteKey(70);
		Console.WriteLine("After delete: ");
		tree.inorder();

		Console.WriteLine("==========================================");
		Console.WriteLine("Numbers of element is BST: {0}", tree.count);

	}
}


