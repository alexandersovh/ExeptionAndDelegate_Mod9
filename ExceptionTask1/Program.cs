using System;

namespace ExceptionTask1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("программва запущена\n");
            MyException my = new MyException("Cлучилось страшное! Но мы уже знаем об этом");
            
            var uri = new UriFormatException(); 
            var noMethod = new NotSupportedException();
            var exMethod = new InvalidOperationException();
            var noIndex = new IndexOutOfRangeException();
            Exception[] array = new Exception[] { my, uri, noMethod, exMethod, noIndex };
            foreach (Exception i in array)
            {
                try
                { 
                    MyException myVoid = new MyException();
                    throw i;
                    
                }
                catch (MyException mex)
                {
                    Console.WriteLine(mex.Message);
                }
                catch (Exception ex) when (ex is UriFormatException)
                {
                    Console.WriteLine("Используется недопустимый универсальный код ресурса(URI)");
                }
                catch (Exception ex) when (ex is NotSupportedException)
                {
                    Console.WriteLine("етод или операция не поддерживается");
                }
                catch (Exception ex) when (ex is InvalidOperationException)
                {
                    Console.WriteLine("Вызов метода недопустим в текущем состоянии объекта");
                }
                catch (Exception ex) when (ex is IndexOutOfRangeException)
                {
                    Console.WriteLine("Индекс находится за пределами границ массива или коллекции");
                }

            }
            Console.WriteLine("\nпрограмма закончила работу");
            Console.ReadKey();
        }
    }

}