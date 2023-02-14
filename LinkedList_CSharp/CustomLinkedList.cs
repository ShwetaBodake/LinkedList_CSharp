using System;
using System.Xml.Linq;

namespace LinkedList_CSharp
{
	public class CustomLinkedList
	{
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Inserted into Linked List :  {0}", node.data);
        }

        public void AddFirst(int data)
        {

            Node Node = new Node(data);
            Node.next = this.head;
            this.head = Node;
            Console.WriteLine("{0}is inserted into LikedList", Node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine(" Linked List is Empty ");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

