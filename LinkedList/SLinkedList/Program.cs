﻿using System;
using System.Collections.Generic;

namespace SLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList<int> list = new LinkedList<int>();
            
            list.Prepend(1);
            Console.WriteLine("post Prepend 1");
            PrintList(list);

            list.Prepend(2);
            Console.WriteLine("post Prepend 2");
            PrintList(list);

            list.Prepend(3);
            Console.WriteLine("post Prepend 3");
            PrintList(list);

            list.Append(4);
            Console.WriteLine("post Append 4");
            PrintList(list);

            list.Append(5);
            Console.WriteLine("post Append 5");
            PrintList(list);

            list.InsertAt(10, 2);
            Console.WriteLine("post InsertAt 10, 2");
            PrintList(list);

            list.InsertAt(11, 3);
            Console.WriteLine("post InsertAt 11, 3");
            PrintList(list);

            list.RemoveAt(3);
            Console.WriteLine("post RemoveAt 11, 3");
            PrintList(list);

            list.RemoveAt(2);
            Console.WriteLine("post RemoveAt 10, 2");
            PrintList(list);

            var node = list.GetAt(2);
            Console.WriteLine("Get At Index 3");
            Console.WriteLine(node.Data);


            list.Reverse();
            Console.WriteLine("Reverse List");
            PrintList(list);

        }

        public static void PrintList(LinkedList<int> list)
        {
            var current = list.FirstNode;
            do
            {
                Console.Write(current.Data + "   ");
                current = current.Next;
            } while (current != null);
            Console.Write("\n");
        }
    }
}
