using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Разработать структуру для решения линейного уравнения 0=kx+b.
            //Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
            //Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры.
            //Осуществить использование экземпляра в программе.

            Console.WriteLine("Введите значение коэффициентов k и b линейного уравнения 0=kx+b");
            Console.Write("k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            LinearEquation equation;
            equation.k = k;
            equation.b = b;
            equation.Root();
            Console.ReadKey();
        }
    }
    struct LinearEquation
    {
        internal double k;
        internal double b;
        internal LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        internal void Root()
        {
            double rootLE = -b/k;
            Console.WriteLine("Корень уравнения: х = {0}", rootLE);
        }
    }
}
