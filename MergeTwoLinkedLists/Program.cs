namespace MergeTwoLinkedLists
{
    using System;
    class SortLists
    {
        public static void Main(string[] args)
        {
            LinkedList<int> numbers1 = new LinkedList<int>();
            LinkedList<int> numbers2 = new LinkedList<int>();
            numbers1.AddLast(1);
            numbers1.AddLast(90);
            numbers1.AddLast(83);
            numbers2.AddLast(84);
            numbers2.AddLast(5);    
            numbers2.AddLast(60);
            foreach (int i in numbers1)
            {
                Console.WriteLine(i);
            }
            //numbers1.Sort();
            //numbers2.Sort();
            foreach (var num in numbers1.Reverse())
            {
                Console.WriteLine(num);
            }
            LinkedList<int> sortedList = new LinkedList<int>();
            foreach (var number in numbers1)
            {
                sortedList.AddLast(number);
            }
            foreach (var number in numbers2)
            {
                sortedList.AddLast(number);
            }
            foreach (var number in sortedList.Order())
            {
                Console.WriteLine(number);
            }

        }
    }
}
