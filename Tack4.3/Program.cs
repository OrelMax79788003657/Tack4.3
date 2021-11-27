using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int C = 0;

            Console.Write("Введите число A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число C: ");
            C = Convert.ToInt32(Console.ReadLine());

            int value = 0;

            int x = 0;
            int y = 0;

            while (x <= A - C)
            {
                y = 0;
                while (y <= B - C)
                {
                    y += C;
                    value++;
                }
                x += C;
            }
            Console.Write(value.ToString() + " квадратов поместится");
            Console.ReadKey();

        }
    }
}
