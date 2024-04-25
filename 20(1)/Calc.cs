using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1_
{
    class Calc<T, K>
    {
        public T Value1 { get; set; }
        public K Value2 { get; set; }
        public Calc() { }
        public Calc(T value1, K value2) 
        { 
          Value1 = value1; 
          Value2 = value2; 
        }
        public void Add()
        {
            if (typeof(T) == typeof(int) || typeof(K) == typeof(int) ||  typeof(T) == typeof(double) || typeof(K) == typeof(double)  || typeof(T) == typeof(string) || typeof(K) == typeof(string))
            {
                double a = Convert.ToDouble(Value1);
                double b = Convert.ToDouble(Value2);
                Console.WriteLine($"{Value1} + {Value2} = {a + b}");
            }
            else
            {
                Console.WriteLine("Неверный тип данных");
            }
        }
        public void Sub()
        {
            if (typeof(T) == typeof(int) || typeof(K) == typeof(int) || typeof(T) == typeof(double) || typeof(K) == typeof(double) || typeof(T) == typeof(string) || typeof(K) == typeof(string))
            {
                double a = Convert.ToDouble(Value1);
                double b = Convert.ToDouble(Value2);
                Console.WriteLine($"{Value1} - {Value2} = {a - b}");
            }
            else
            {
                Console.WriteLine("Неверный тип данных");
            }
        }
        public void Div()
        {
            if (typeof(T) == typeof(int) || typeof(K) == typeof(int) || typeof(T) == typeof(double) || typeof(K) == typeof(double) || typeof(T) == typeof(string) || typeof(K) == typeof(string))
            {
                double a = Convert.ToDouble(Value1);
                double b = Convert.ToDouble(Value2);
                Console.WriteLine($"{Value1} / {Value2} = {a / b:f2}");
            }
            else
            {
                Console.WriteLine("Неверный тип данных");
            }
        }
        public void Mul()
        {
            if (typeof(T) == typeof(int) || typeof(K) == typeof(int) || typeof(T) == typeof(double) || typeof(K) == typeof(double) || typeof(T) == typeof(string) || typeof(K) == typeof(string))
            {
                double a = Convert.ToDouble(Value1);
                double b = Convert.ToDouble(Value2);
                Console.WriteLine($"{Value1} * {Value2} = {a * b:f2}");
            }
            else
            { 
                Console.WriteLine("Неверный тип данных");
            }
        }

    }
}
