using System;

namespace DelegateTasc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("начнем");

            NamberReade nr = new NamberReade();
            nr.GoNumr();

            Console.ReadLine();
        }
    }
}
