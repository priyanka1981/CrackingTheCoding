using System;
namespace test.LinkList
{
    public class LinkListMain
    {
        public LinkListMain()
        {
        }

        public static void Main(string[] args)
        {
            //int[] A = { 1, 2, 4, 6, 1, 2,-1,-2 };
           // int i = solution(A);

            LinkListNode head = new LinkListNode(1);
            LinkList linkList = new LinkList();
            linkList.AddToTail(head);
            linkList.AddToTail(new LinkListNode(2));
            linkList.AddToTail(new LinkListNode(1));
            linkList.AddToTail(new LinkListNode(3));
            linkList.AddToTail(new LinkListNode(4));
            linkList.AddToTail(new LinkListNode(1));
            //RemoveDuplicate(linkList);
            RemoveDup(linkList);
            LinkListNode node = FindNSecond(3, linkList);

        }

        public static int solution(int[] A)
        {
            Boolean[] array = new Boolean[1000000];
            foreach (int num in A)
            {
                if (num < 1)
                    continue;
                else
                    array[num] = true;
            }

            int counter = 1;
            for (; counter <= 1000000; counter++)
            {
                if (!array[counter])
                    break;
            }

            if (counter == 1000000+1)
            {
                return 1;
            }
            else
            {
                return counter;
            }
        }



        public static void RemoveDuplicate(LinkList linkList)
        {
            //121341
            LinkListNode current = linkList.head.next;
            LinkListNode prevoius= linkList.head;
            while (current != null)
            {
                LinkListNode runner = linkList.head;
                while (current != runner)
                {
                    if (current.data == runner.data)
                    {
                        LinkListNode temp = current.next;
                        prevoius.next = temp;
                        current = temp;
                        break;

                    }
                    //else if (runner.next != null)
                    runner = runner.next;
                }


                if (runner == current)
                {
                    prevoius = current;
                    current = current.next;
                }
            }



            }


        public static void RemoveDup(LinkList linkList){
            Boolean[] bool_array = new Boolean[10];
            LinkListNode current = linkList.head;
            LinkListNode previous = linkList.head;
            while(current.next!=null){
               
                if (!bool_array[current.data])
                {
                    bool_array[current.data] = true;
                    previous = current;
                    current = current.next;
                }
                else
                {
                    LinkListNode temp = current.next;
                    previous.next = temp;
                    current = temp;
                }

            }
        }


        public static LinkListNode FindNSecond(int n,LinkList linkList)
        {
            LinkListNode p1 = linkList.head;
            LinkListNode p2 = linkList.head;
            for (int j = 0; j < n - 1;j++){
                if (p2 == null) { return null; }
                p2 = p2.next;
            }
            while(p2.next !=null){
                p1 = p1.next;
                p2 = p2.next;
            }
            return p1;
        }
        //}
    }
}

