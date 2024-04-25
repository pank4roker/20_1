using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1_
{
    class Calc <Ttype,Ptype>
    {
        private Ttype x;
        private Ptype y;

        public Calc() { }
        public Calc(Ttype x, Ptype y)
        {
            X = x;
            Y = y;
        }

        public Ttype X { get => x; set => x = value; }
        public Ptype Y { get => y; set => y = value; }

        public void Mul(Ttype x, Ptype y)
        {
            if(typeof(int) && typeof(double))
            {
                Ttype x = a;
                int y = b;
                Console.WriteLine(a+b);
            }
         
        }
        
    }
}
