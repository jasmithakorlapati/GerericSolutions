namespace CreateTupleBasedDict
{

    class Tuple_Based_Dict
    {
        public static void Main(string[] args)
        {
            Dictionary<(int, string), string> dict = new Dictionary<(int, string), string>();
            dict.Add((1, "Appel"), "fruit1");
            dict.Add((2, "Banana"), "fruit2");
            dict.Add((1, "Jack"), "fruit3");
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item);
            }
        }

    }
}
