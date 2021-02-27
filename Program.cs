using System;

namespace PracticePartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
            Console.WriteLine(Add(5, 7));
        }

        static void Print()
        {
            Console.WriteLine("Hello From Print method");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
