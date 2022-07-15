using System;

namespace App1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Calculando Trapézio

            double b1, b2, h, area;//a letra a e b são as bases, e o h é a altura e a area será o resultado
            b1 = 6.0;
            b2 = 8.0;
            h = 5.0;

            area = (b1 + b2) / 2.0 * h;

            Console.WriteLine("A area do trapésio é = " + area);
        }
    }
}