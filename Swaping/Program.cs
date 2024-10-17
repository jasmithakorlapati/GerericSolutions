namespace Swaping
{
   
    class GenericSwap
    {
        public static void Swap<T>(int a, int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public static void Main(string[] args)
        {
            Swap<int>(2, 3);
        }
    }

}
