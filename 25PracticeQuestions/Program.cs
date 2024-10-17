using System.Collections.Generic;
namespace _25PracticeQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           
               
                    Stack<int> s = new Stack<int>();
                    s.Push(2);
                    s.Push(3);
                    s.Push(89);
                    s.Push(76);
            Console.WriteLine(s.Count());
                    foreach (var item in s)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

        }
    
