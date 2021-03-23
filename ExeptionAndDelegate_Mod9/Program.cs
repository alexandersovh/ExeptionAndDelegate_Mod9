using System;

namespace ExeptionAndDelegate_Mod9
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            Console.Write("введите пятизначное число ");

    //            string s = Console.ReadLine();
    //            int i = Convert.ToInt32(s);


    //            if (s.Length < 5)
    //                throw new Exception("число слишком маленькое!");

    //            Console.WriteLine("вы ввели число: {0}", i);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("произошло исключение " + ex.Message);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("конец");
    //        }
    //        Console.ReadKey();
    //    }
    //}
    class Person
    {
        public string Name { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                    throw new PersonException("Лицам до 18 регистрация запрещена", value);
                else
                    age = value;
            }
        }
    }
    class PersonException : ArgumentException
    {
        public int Value { get; }
        public PersonException(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person { Name = "Tom", Age = 15 };
            }
            catch (PersonException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.Value}");
            }
            Console.Read();
        }
    }
}
