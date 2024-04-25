using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Calc<int, int> calc = new Calc<int, int>(x,y);
            Console.WriteLine($"x * y = {calc.Mul()}");
            Calc<int, double> calc1 = new Calc<int, double>(x, y);
            Console.WriteLine($"x * y = {calc1.Mul()}");
            Calc<int, string> calc2 = new Calc<int, string>(x, "12");
            try
            {
                Console.WriteLine($"Add: {calc2.Mul()}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"x * y = {calc2.Mul()}");
            Console.ReadKey();
        }
    }
}
