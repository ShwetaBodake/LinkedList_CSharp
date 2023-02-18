using System.Collections.Generic;

namespace LinkedList_CSharp
{
class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List ");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.Add(56);
            customLinkedList.Add(30);
            customLinkedList.Add(70);
            customLinkedList.DeleteLastNode();
            customLinkedList.Display();
            //customLinkedList.Add(56);
            //customLinkedList.Add(30);
            //customLinkedList.Add(70);
            //customLinkedList.Display();
            //customLinkedList.AddFirst(70);
            //customLinkedList.AddFirst(30);
            //customLinkedList.AddFirst(56);
            //customLinkedList.Display();
            //Console.ReadLine();
            //customLinkedList.Append(56);
            //customLinkedList.Append(30);
            //customLinkedList.Append(70);
            //customLinkedList.Display();

            //customLinkedList.Add(56);
            //customLinkedList.Add(70);
            //customLinkedList.Display();

            //int a = customLinkedList.Search(56);
            //Console.WriteLine("Index Position Of 56 is " + a);
            //customLinkedList.InsertParticularPosition(a + 1, 30);
            //customLinkedList.Display();

            Console.ReadLine();
        }
    }
}

