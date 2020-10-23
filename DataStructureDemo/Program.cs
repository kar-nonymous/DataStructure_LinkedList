using System;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(70);
            list.Append(30);
            list.Append(56);
            list.SearchValue(30);
        }
    }
}
