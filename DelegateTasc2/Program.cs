using System;

namespace DelegateTasc2
{
    class Program
    {
        public static string[] Name = new string[] { "Алекс", "Коля", "Маша", "Ольга", "Яна" };
        static void Main(string[] args)
        {
            NamberReade namberReade = new NamberReade();
            namberReade.NumberReadeEvent += showNamber;
            string stoper = "";
            while (stoper != "stop")
            {
                try
                {
                    namberReade.Read();
                    Console.WriteLine("введите 'stop' для остановки программы");
                    stoper = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("число введено некорректно");
                }

            }
        }
        public static void showNamber(int num, string[] name)
        {
            switch (num)
            {
                case 1: SortArray.SortArrayAZ(name); break;
                case 2: SortArray.SortArrayZA(name); break;
            }
        }

    }
}