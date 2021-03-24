using System;

namespace ExeptionAndDelegate_Mod9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("введите пятизначное число ");

                string s = Console.ReadLine();
                int i = Convert.ToInt32(s);


                if (s.Length < 5)
                    throw new Exception("число слишком маленькое!");

                Console.WriteLine("вы ввели число: {0}", i);
            }
            catch (Exception ex)
            {
                Console.WriteLine("произошло исключение " + ex.Message);
            }
            finally
            {
                Console.WriteLine("конец");
            }
            Console.ReadKey();
        }
    }
}