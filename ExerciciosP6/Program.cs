using System;
using System.Globalization;

namespace ExerciciosP6 {
    public static class Program {
        public static void Main(string[] args) {

            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo, pi;
            pi = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse((valores[0]), CultureInfo.InvariantCulture);
            B = double.Parse((valores[1]), CultureInfo.InvariantCulture);
            C = double.Parse((valores[2]), CultureInfo.InvariantCulture);
            
            triangulo = A * C / 2;
            circulo = pi * Math.Pow(C, 2);
            trapezio = (A + B) / 2 * C;
            quadrado = Math.Pow(B, 2);
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: {0}", triangulo.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("CIRCULO: {0}", circulo.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("QUADRADO: {0}", quadrado.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("RETANGULO: {0}", retangulo.ToString("F3"), CultureInfo.InvariantCulture);
        
        }

    }
}