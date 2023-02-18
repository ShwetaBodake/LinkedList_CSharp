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
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        public bool Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                   break;
                }
                node = node.next;
                count++;
            }
            if (node == null)
            {
                Console.WriteLine(node + "not present in linkedlist");
                return false;
            }
            else
            {
                Console.WriteLine(node.data + "  present at " + count + " position in linkedlist");
                return true;
            }
        }

        //public void DeleteLastNode()
        //{
        //    Node temp = head;
        //    if (temp == null)
        //    {
        //        Console.WriteLine("Linked list is empty");
        //    }
        //    else if (temp.next == null)
        //    {
        //        int data = temp.data;
        //        temp = null;
        //        head = temp;
        //        Console.WriteLine("{0} is deleted", data);
        //    }
        //    else
        //    {
        //        while (temp.next.next != null)
        //        {
        //            temp = temp.next;
        //        }
        //        int lastDeletedNode = temp.next.data;
        //        temp.next = null;
        //        Console.WriteLine("{0} is deleted", lastDeletedNode);
        //    }
        //}

        //public void RemoveFirstNode()
        //{
        //    if (head == null)
        //        Console.WriteLine("Its empty please add nodes");
        //    else
        //        Console.WriteLine("{0} is removed", head.data);
        //    head = head.next;
        //}


        //public Node InsertParticularPosition(int Position, int Data)
        //{
        //    if (Position < 1)
        //    {
        //        Console.WriteLine("Invalid Position");
        //    }
        //    if (Position == 1)
        //    {
        //        var newNode = new Node(Data);
        //        newNode.next = this.head;
        //        head = newNode;
        //    }
        //    else
        //    {
        //        while (Position-- != 0)
        //        {
        //            if (Position == 1)
        //            {
        //                Node node = new Node(Data);
        //                node.next = this.head.next;
        //                head.next = node;
        //                break;
        //            }
        //            head = head.next;
        //        }
        //        if (Position != 1)
        //        {
        //            Console.WriteLine("Position Out Of Range ");
        //        }

        //    }
        //    return head;

        //}


    }
}

