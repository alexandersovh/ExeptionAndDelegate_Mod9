using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTasc2
{
    class SortArray
    {
        public static void SortArrayAZ(string[] array)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for(int i = 0; i < array.Length - 1; ++i)
                {
                    if (array[i].CompareTo(array[i+1]) > 0)
                    {
                        string temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        flag = true;
                    }
                }
            }
            foreach (string s in array)
                Console.WriteLine(s);
        }
        public static void SortArrayZA(string[] array)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < array.Length - 1; ++i)
                {
                    if (array[i].CompareTo(array[i + 1]) < 0)
                    {
                        string temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        flag = true;
                    }
                }
            }
            foreach (string s in array)
                Console.WriteLine(s);
        }
    }
}
