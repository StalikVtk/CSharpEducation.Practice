using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;

            Console.Write("Как Вас зовут? ");
            myName = Console.ReadLine();

            Console.WriteLine($"Добро пожаловать к нам: {myName}");
            Console.ReadKey();
        }
    }
}
