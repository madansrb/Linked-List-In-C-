using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList linkedlistobject = new LinkList();
            linkedlistobject.AddLast("One");
            linkedlistobject.AddLast("Two");
            linkedlistobject.AddLast("Three");
            linkedlistobject.AddLast("Four");
            linkedlistobject.AddFirst("Add data to first data");
            linkedlistobject.ReadAll();
        }
    }
}
