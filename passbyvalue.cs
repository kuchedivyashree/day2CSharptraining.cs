using System;
using System.Linq;



namespace ConsoleApp2
{
    internal class passing
    {
        public void doSwap(int a, int b)
        {
            int temp;
            temp = a;
             a = b;
             b = temp;
            Console.WriteLine("after swapping in method: a = {0}, b = {1}",a,b);
         }
    
         static void Main(string[] args)
         {
        passing n = new passing();
        int x = 1;
        int y = 2;

        Console.WriteLine("before swapping:x={0},y={1}", x, y);
        n.doSwap(x, y);
        Console.WriteLine("after swapping:x={0},y={1}", x, y);
        Console.ReadLine();


         }



        
    }
}
