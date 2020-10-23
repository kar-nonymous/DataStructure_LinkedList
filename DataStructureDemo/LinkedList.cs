using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    public class LinkedList
    {
        public Node head;
        /// <summary>
        /// UC1
        /// Inserts the last.
        /// </summary>
        /// <param name="new_data">The new data.</param>
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
                this.head = new_node;
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("Insert into list " + new_node.data);
        }
        /// <summary>
        /// Gets to the last node
        /// </summary>
        /// <returns></returns>
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
                temp = temp.next;
            return temp;
        }
        /// <summary>
        /// Displays linked list content
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("Linked is empty");
                return;
            }
            else
            {
                while(temp!=null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }
            }
        }
        /// <summary>
        /// UC 2
        /// Inserts data at the front.
        /// </summary>
        /// <param name="new_data">The new data.</param>
        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("Inserted in " + new_node.data);
        }
    }
}
