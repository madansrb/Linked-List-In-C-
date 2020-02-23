using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
   public class LinkList
    {
        Node head = null; //starting of the node.

        public void  AddLast(object data)
        {

            Node newitem = new Node();
            newitem.data = data;
            // if head is null that means it is the first item and  add the  new item and  set next node to null
            if (head ==null)
            {
                
                head = newitem;
                head.next = null;
            }
            else
            {
                // if the head is not null and find out the last node by loop
                Node current = head;
                while(current.next  != null)
                {
                    current = current.next;
                }

                current.next = newitem;
            }


        }

        public void AddFirst(object data)
        {
            Node newitem = new Node();
            newitem.data = data;
            newitem.next = head;
            head  = newitem;
        }

        public void ReadAll()
        {
            Node current = head;
            // loop until the last node
            while(current.next !=null)
            {
                Console.WriteLine(current.data);
               current = current.next;
            }

            Console.WriteLine(current.data);
            Console.ReadLine();

        }
    }
}
