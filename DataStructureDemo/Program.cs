using System;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.InsertFront(70);
            list.InsertFront(56);
            list.InsertFront(30);
            list.Display();
        }
    }
}
