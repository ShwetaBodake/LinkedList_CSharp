namespace LinkedList_CSharp
{
class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List ");
            CustomLinkedList customLinkedList = new CustomLinkedList();
            //customLinkedList.Add(56);
            // customLinkedList.Add(30);
            // customLinkedList.Add(70);
            // customLinkedList.Display();
            customLinkedList.AddFirst(70);
            customLinkedList.AddFirst(30);
            customLinkedList.AddFirst(56);
            customLinkedList.Display();
            Console.ReadLine();
        }
    }
}

