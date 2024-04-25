using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calc<int, int> calculator = new Calc<int, int>(5, 2);
            Console.WriteLine("1 Объект(int/int)");
            calculator.Add();
            calculator.Sub();
            calculator.Mul();
            calculator.Div();
            Calc<int, double> calculator1 = new Calc<int, double>(2, 4.5);
            Console.WriteLine("2 Объект(int/double)");
            calculator1.Add();
            calculator1.Sub();
            calculator1.Mul();
            calculator1.Div();
            Calc<int, string> calculator2 = new Calc<int, string>(3, "5");
            Console.WriteLine("3 Объект(int/string)");
            calculator2.Add();
            calculator2.Sub();
            calculator2.Mul();
            calculator2.Div();
            Console.ReadLine();
        }
    }
}
