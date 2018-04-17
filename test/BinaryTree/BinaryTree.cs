using System;
namespace test.BinaryTree
{
    public class BinaryTree
    {
        public BinaryTree()
        {
        }

         public BinaryTreeNode<int> root = new BinaryTreeNode<int>(4);
        //root.setIs_root(true);


        public void Add(BinaryTreeNode<int> parent, BinaryTreeNode<int> node){
           // if (this.root == null)
               // root = node;
            if(node.data.CompareTo(parent.data)<0)
            {
                if (parent.left_child != null)
                {
                    parent.left_child.height += 1;
                    root.height += 1;
                    node.depth += 1;
                    Add(parent.left_child, node);
                }
                else
                    parent.left_child = node;
            }
            else if(node.data.CompareTo(parent.data)>0)
            {
                if (parent.right_child != null)
                {
                    parent.right_child.height += 1;
                    root.height += 1;
                    node.depth += 1;
                    Add(parent.right_child, node);
                }
                else
                    parent.right_child = node;
            }
        }

        public void InOrderTravasal(BinaryTreeNode<int> root){
            if (root == null) return;
            Console.WriteLine(root.ToString());
            InOrderTravasal(root.left_child);
            InOrderTravasal(root.right_child);
        }

        public void DFS(){
           System.Collections.Stack  stack = new System.Collections.Stack();
            stack.Push(this.root);
            while(stack.Count>0)
            {
                BinaryTreeNode<int> node = (BinaryTreeNode<int>)stack.Pop();
                Console.WriteLine(node.data);
               
                if(node.right_child !=null)
                    stack.Push(node.right_child);
                if (node.left_child != null)
                    stack.Push(node.left_child);
               // Stack.Stack.
            }
        }

        public void BFS(){
            Console.WriteLine("BFS =>......");
            System.Collections.Queue queue = new System.Collections.Queue();
            queue.Enqueue(root);
            while(queue.Count>0){
                BinaryTreeNode<int> node = (BinaryTreeNode<int>)queue.Dequeue();
                Console.WriteLine(node.data);
                if (node.right_child != null) queue.Enqueue(node.right_child);
                if (node.left_child != null) queue.Enqueue(node.left_child);

            }
        }
    }
}
