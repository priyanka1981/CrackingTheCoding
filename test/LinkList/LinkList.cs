using System;
namespace test.LinkList
{
    public class LinkList
    {
        public LinkList()
        {
        }

        public LinkListNode head;
        public LinkListNode tail;
        public int Count;
        public void AddToTail(LinkListNode node)
        {
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else{
                tail.next = node;
                tail = node;
            }
            //count++;
        }
    }
}
