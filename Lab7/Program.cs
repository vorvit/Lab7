using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 7-1. О большей площади двух треугольников
            double s;
            Console.WriteLine("Введите длины сторон первого треугольника:");
            Console.WriteLine("сторона А:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("сторона B:"); 
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("сторона С:"); 
            double c = Convert.ToDouble(Console.ReadLine());
            CalcTriangleSquare(a, b, c, out s);
            double s1 = s;
            Console.WriteLine("Введите длины сторон второго треугольника:");
            Console.WriteLine("сторона А:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("сторона B:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("сторона С:");
            c = Convert.ToDouble(Console.ReadLine());
            CalcTriangleSquare(a, b, c, out s);
            double s2 = s;
            if (s1 > s2)
            {
                Console.WriteLine("Площадь первого треугольника S1 = {0}, больше площади второго S2 = {1}", s1, s2);
            }
            if (s1 < s2)
            {
                Console.WriteLine("Площадь второго треугольника S2 = {0}, больше площади первого S1 = {1}", s2, s1);
            }
            if (s1 == s2)
            {
                Console.WriteLine("Площади треугольников равны S1 = S2 = {0}", s1);
            }
            Console.WriteLine("Для завешения - нажмите любую клавишу");
            Console.ReadKey();
        }
        static void CalcTriangleSquare(double a, double b, double c, out double s)
        {
            double hp = (a + b + c) / 2;
            s = Math.Sqrt(hp * (hp - a) * (hp - b) * (hp - c));
        }
    }
}
