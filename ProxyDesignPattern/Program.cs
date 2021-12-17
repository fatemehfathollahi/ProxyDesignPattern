using System;

namespace ProxyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MathProxy mathProxy = new MathProxy();

            Console.WriteLine("4+2=" + mathProxy.Add(4,2));
            Console.WriteLine("4*2=" + mathProxy.Mul(4, 2));
            Console.WriteLine("4-2=" + mathProxy.Sub(4, 2));
            Console.WriteLine("4/2=" + mathProxy.Div(4, 2));

            //
            Console.ReadLine();
        }
    }
}
