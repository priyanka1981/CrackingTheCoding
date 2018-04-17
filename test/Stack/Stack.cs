using System;
namespace test.Stack
{
    public class Stack
    {
        public Stack()
        {
        }

        public StackNode head;
        public StackNode tail;
        StackNode[] array = new StackNode[10];
        int index = 0;
        public void Push(StackNode node){
            if (this.head == null)
            {
                this.head = node;
                array[index] = node;
            }
            else
            {

                array[index++] = node;
            }
                
        }


        public StackNode Pop(){
            StackNode node;
            if (head == null)
                return null;
            else{
                return node = array[index--];
            }
        }

        //public StackNode Min(){
            
        //}
    }
}
