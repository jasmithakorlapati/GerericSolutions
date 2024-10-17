namespace IntersectionOfLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            List<int> list2 = new List<int>();
            list2.Add(2);
            list2.Add(3);
            list2.Add(9);
            list2.Add(10);
            list2.Add(11);

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list[i].Equals(list2[j]))
                    {
                        Console.WriteLine(list[i]);
                    }

                }
            }
        }
    }
}
        

