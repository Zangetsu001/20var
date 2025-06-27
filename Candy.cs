using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Candy:Tovar
    {
        public double Ves;
        public override void Calc()
        {
            Console.WriteLine($"{Name}: {Ves} * {Price} = {Ves*Price}");
        }
    }
}
