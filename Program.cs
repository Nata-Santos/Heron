using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double p, sp, area;
            
            Console.WriteLine("Digite os lados do Triângulo desejado.");
            Console.Write("Lado 1..►");
            a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Lado 2..►");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 3..►");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------");

            p = a + b + c;
            sp = p / 2;
            Console.WriteLine($"\nSemiperímetro..►► {sp} ");

            area = Math.Sqrt(sp*(sp - a)*(sp - b)*(sp - c));
            Console.WriteLine($"\nÁrea......►►► {area}");


        }
    }
}
