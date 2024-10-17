using System;
using System.Collections.Generic;
namespace SortDict
{
    

    class SortedDict
    {
        public static void Main(string[] args)
        {
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();

            sd.Add(1, "Jas");
            sd.Add(2, "Puji");
            sd.Add(3, "bargu");
            sd.Add(4, "renu");
            PriorityQueue<int,string> pq = new PriorityQueue<int,string>();
            foreach (var item in sd)
            {
                pq.Enqueue(item.Key, item.Value);
            }

            while( pq.Count>0)
            {
                var res=pq.Dequeue();
                Console.WriteLine(res);
            }
        }
    }
}
