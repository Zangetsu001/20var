using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tovar[] tovary =   
            {
                new Book { Name = "Роман", Price = 10, Kvo = 3 },
                new Pen { Name = "Ручка", Price = 3, Kvo = 5 },
                new Candy { Name = "Конфеты", Price = 8, Ves = 6 }
            };

            foreach (var t in tovary)
                t.Calc();
        }
    }
}
