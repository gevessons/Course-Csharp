using System;
using System.Drawing;
using System.Globalization;

namespace Exercicio2 {
    public static class Program{
        public static void Main(string[] args) {
            
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = Math.Pow(raio, 2) * pi;

            Console.WriteLine("A={0}", area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}