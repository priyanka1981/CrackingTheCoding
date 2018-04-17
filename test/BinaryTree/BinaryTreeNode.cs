using System;
namespace test.BinaryTree
{
    public class BinaryTreeNode<T> where T:IComparable
    {
        public BinaryTreeNode()
        {
        }

        public BinaryTreeNode(T _data){
            this.data = (T)_data;
        }

        public T data;
        public BinaryTreeNode<T> left_child;
        public BinaryTreeNode<T> right_child;
        public BinaryTreeNode<T> parent;

        public int height;
        public int depth;

        public bool is_root = false;

        public bool isIs_root()
        {
            return is_root;
        }

        public void setIs_root(bool is_root)
        {
            this.is_root = is_root;
        }
        
        public new string ToString(){
            string str = "Node [value=" + data + ", is_root=" + is_root;
            if (left_child != null)
                str = str + ", left_child=" + left_child.data;
            if (right_child != null)
                str = str + "right_child=" + right_child.data;
            str = str + ", height=" + height + ", depth=" + depth + "]";
            return str;
        }
    }
}
