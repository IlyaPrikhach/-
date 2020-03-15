using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            Console.WriteLine("Введите число");
            try
            {
                string строкаВвода = Console.ReadLine();
                string[] аргумент = строкаВвода.Replace('.',',').Split(' ');
                x = Convert.ToInt16(аргумент[0]);
            }
            catch
            {
                Console.WriteLine("неверные данные");
                Main(args);
            }
            double y = Math.Pow(x, 2);
            Console.WriteLine("Ваше число в квадрате");
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
