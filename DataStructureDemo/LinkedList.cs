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
        /// <param name="newData">The new data.</param>
        public void InsertLast(int newData)
        {
            Node newNode = new Node(newData);
            if (this.head == null)
                this.head = newNode;
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
            Console.WriteLine("Insert into list " + newNode.data);
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
        /// <param name="newData">The new data.</param>
        public void InsertFront(int newData)
        {
            Node newNode = new Node(newData);
            newNode.next = this.head;
            this.head = newNode;
            Console.WriteLine("Inserted in " + newNode.data);
        }
        /// <summary>
        /// UC3
        /// Appends the specified new data.
        /// </summary>
        /// <param name="newData">The new data.</param>
        public void Append(int newData)
        {
            Node newNode = new Node(newData);
            if (this.head == null)
                this.head = newNode;
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
            Console.WriteLine("Insert into list " + newNode.data);
        }
        /// <summary>
        /// UC4
        /// Inserts data at particular position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="newData"></param>
        /// <returns></returns>
        public Node InsertAtParticularPosition(int position, int newData)
        {
            if (position < 1)
                Console.WriteLine("The Position passed is invalid");
            else if (position == 1)
            {
                Node newNode = new Node(newData);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node temp = new Node(newData);
                        temp.next = this.head.next;
                        head.next = temp;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position Out Of Range");
            }
            Console.WriteLine("Inserted Value is - " + head.next.data);
            return head;
        }
        /// <summary>
        /// UC 5
        /// Deletes the first node.
        /// </summary>
        /// <returns></returns>
        public Node DeleteFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        /// <summary>
        /// UC 6
        /// Deletes the last node.
        /// </summary>
        /// <returns></returns>
        public Node DeleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
                return null;
            if (this.head.next == null)
            {
                this.head = null;
                return null;
            }
            while (newNode.next.next != null)
                newNode = newNode.next;
            return null;
        }
    }
}
