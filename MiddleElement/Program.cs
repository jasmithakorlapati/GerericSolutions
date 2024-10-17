namespace MiddleElement
{
    using System;
    class MiddleElement
    {
        public static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(80);
            list.AddLast(90);
            list.AddLast(100);
            list.AddLast(200);
            list.AddLast(300);
            list.AddLast(300);
            int total = list.Count();
            Console.WriteLine(list.ElementAt((total / 2)));
           
        }
    }

}

