using System;
namespace test.BinaryTree
{
    public class BinaryTreeMain
    {
        public BinaryTreeMain()
        {
        }

        public static void Main(string[] args)
        {
            BinaryTreeNode<int> root = new BinaryTreeNode<int>(4);
            BinaryTreeNode<int> left = new BinaryTreeNode<int>(3);
            BinaryTree tree = new BinaryTree();
            tree.root = root;
            tree.Add(root, left);
            tree.Add(root, new BinaryTreeNode<int>(6));
            tree.Add(left, new BinaryTreeNode<int>(1));
            tree.Add(left, new BinaryTreeNode<int>(2));
            tree.InOrderTravasal(tree.root);
            tree.DFS();
            tree.BFS();
        }
    }
}
