using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class passbyout
    {
        void getValues(out int x,out int y)
        {
            x = 10;
            y = 20;
        }
        static void Main(string[] args)
        {
            passbyout n = new passbyout();
            int a = 1;
            int b = 2;

            Console.WriteLine("before passing in method:a={0},b={1}", a, b);
            n.getValues(out a, out b);
            Console.WriteLine("after passing in method;a={0},b={1}", a, b);
            Console.ReadLine();
        }
    }
}
