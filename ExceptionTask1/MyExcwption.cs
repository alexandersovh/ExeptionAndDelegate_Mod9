using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask1
{
    public class MyException : Exception
    {
        public MyException()
        {
            Console.Write("\t Oшибка: ");
        }
        public MyException(string message) : base(message)
        { }

    }
}
