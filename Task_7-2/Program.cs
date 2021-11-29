using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_2
{
    class Program
    {
        static void Main(string[] args)
        {//Задача 7-2. О методе вычисления объема и площади поверхности куба по длине его ребра
            double s, v;
            Console.WriteLine("Введите длину ребра куба:");
            double a = Convert.ToDouble(Console.ReadLine());
            CalcCube(a, out s, out v);
            Console.WriteLine("Площадь поверхности граней куба S = {0}", s);
            Console.WriteLine("Объем куба V = {0}", v);
            Console.WriteLine("Для завешения - нажмите любую клавишу");
            Console.ReadKey();
        }
        static void CalcCube(double a, out double s, out double v)
        {
            s = 6 * a * a;
            v = a * a * a;
        }
    }
}