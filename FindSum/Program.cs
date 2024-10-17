namespace FindSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum=30;
            List<int> list1 = new List<int>();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            List<int> list2 = list1.ToList();
            list2.Add(40);
            list2.Add(70);
            list2.Add(30);
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (sum == (list1[i] + list2[j]))
                    {
                        Console.WriteLine(list1[i] + "," + list2[i]);
                    }

                }
            }
        }
    }
}
