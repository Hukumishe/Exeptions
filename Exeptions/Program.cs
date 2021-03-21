using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckExeptions cl = new CheckExeptions();

            try
            {
                string str = "abasdasdabsasda";
                Console.WriteLine("Тест 1");
                cl.checkInt(str);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                int check = 1020;
                Console.WriteLine("Тест 2");
                cl.checkInt(check);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }

    class CheckExeptions
    {
        public void checkInt(object data)
        {
            if (data is int)
            {
                throw new Exception("Ошибка: Использован тип int");
            }
            else
            {
                Console.WriteLine(data);
            }
        }
    }

}
