namespace CircularLinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class CircularLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public void AddNode(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                newNode.Next = Head;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
                Tail.Next = Head;
            }
        }
        public void PrintList()
        {
            Node temp = Head;
            if (Head != null)
            {
                do
                {
                    Console.WriteLine(temp.Data + " ");
                    temp = temp.Next;
                }
                while (temp != Head);
            }
            Console.WriteLine();
        }
        public void DeleteNode(int key)
        {
            if (Head == null)
            {
                return;
            }
            if (Head.Data == key && Head.Next == Head)
            {
                Head = null;
                return;
            }
            Node temp = Head;
            while (temp.Next != Head)
            {
                if (temp.Next.Data == key)
                {
                    temp.Next = temp.Next.Next;
                    return;
                }
                temp = temp.Next;
            }
            if (temp.Next.Data == key)
            {
                Head = Head.Next;
                temp.Next = Head;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList cir=new CircularLinkedList();
            cir.AddNode(1);
            cir.AddNode(2);
            cir.AddNode(3);
            cir.AddNode(4);
            cir.AddNode(5);
            cir.PrintList();
            cir.DeleteNode(3);
            cir.PrintList();
        }
    }

}
