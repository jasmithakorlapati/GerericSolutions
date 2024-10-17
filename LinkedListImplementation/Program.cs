namespace LinkedListImplementation
{
 class ReverseLinkedList
    {
public static void Main(string[] args)
    {
        LinkedList<int> l = new LinkedList<int>();
       
          l.AddFirst(1);
          l.AddFirst(2);
          l.AddFirst(3);
          l.AddFirst(4);
          foreach(var item in l)
            {
                Console.WriteLine(item);
            }
          int count = l.Count();
          for(int i=count-1;i>=0;i--)
            {
                Console.Write(l.ElementAt(i)+" "); 
            }

        
    }
}
}
