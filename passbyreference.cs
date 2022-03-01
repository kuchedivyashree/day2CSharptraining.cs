using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class passbyreference
    {

        void doSwap(ref int x, ref int y)
        {

            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            passbyreference n = new passbyreference();
            int a = 1;
            int b = 2;

            Console.WriteLine("before swapping :a={0},b={1}", a, b);
            n.doSwap(ref a, ref b);
            Console.WriteLine("after swapping: a ={0},b ={1}", a, b);
            Console.ReadLine();
        }
            
    }
}
