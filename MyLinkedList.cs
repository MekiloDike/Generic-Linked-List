using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LinkedListTask
{
    internal class MyLinkedList
    {
        public Node head = null;
        public int total = 0;
        public void AddToMyLinkedList(int data)
        {
           var newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                total++;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
                total++;
            }

        }
        public void printMyLinkedList()
        {
             Node current = head;
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(current.Data + "---->");
                current = current.Next;
            }



        }


    }
}
