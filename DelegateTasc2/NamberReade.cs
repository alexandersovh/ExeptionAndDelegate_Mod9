using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTasc2
{
    class NamberReade
    {

        public delegate void NumberReadeDelegate(int namber, string[] name);
        public event NumberReadeDelegate NumberReadeEvent;
        public void Read()
        {

            Console.WriteLine("для сортировки введите число 1 (сортировка А-Я) или 2 (сортировка Я-А)");

            int numSort = Convert.ToInt32(Console.ReadLine());

            if (numSort != 1 && numSort != 2) throw new FormatException();

            ReadEnter(numSort, Program.Name);

        }
        public virtual void ReadEnter(int namber, string[] name)
        {
            NumberReadeEvent?.Invoke(namber, name);
        }

    }
}
