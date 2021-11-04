using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltDataStructs
{
    class LinkedListTest
    {
        public string[] NameArray = new string[] { "Kasper", "Terje", "Joakim", "Linda" };
        public LinkedList<string> LinkedList = new();
        public LinkedListTest()
        {
            LinkedList.AddFirst("Ola");
            foreach (var name in NameArray)
            {
                LinkedList.AddLast(name);
            }

            var currentNode = LinkedList.First;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }

        }
    }
}
