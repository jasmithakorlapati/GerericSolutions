using System.Collections.Generic;

namespace RemoveDuplicates
{
    using System;
    class RemoveDuplicates
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(90);
            list.Add(90);
            list.Add(70);
            list.Add(8);
            list.Add(56);
            list.Add(8);


            HashSet<int> hs = new HashSet<int>(list);
            {
                foreach (var item in hs)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
