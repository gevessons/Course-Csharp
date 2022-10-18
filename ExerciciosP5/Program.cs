using System;
using System.Globalization;

namespace Course {
    public static class Program {
        public static void Main(string[] args) {
            
            int cod1, cod2, qtde1, qtde2;

            double valorU1, valorU2, valorT;

            string[] valor = Console.ReadLine().Split(' ');

            cod1 = int.Parse(valor[0]);
            qtde1 = int.Parse(valor[1]);
            valorU1 = double.Parse(valor[2], CultureInfo.InvariantCulture);

            double valorTU1 = qtde1 * valorU1;


            valor = Console.ReadLine().Split(' ');

            cod2 = int.Parse(valor[0]);
            qtde2 = int.Parse(valor[1]);
            valorU2 = double.Parse(valor[2], CultureInfo.InvariantCulture);

            valorT = (qtde1 * valorU1) + (qtde2 * valorU2);

            Console.WriteLine("VALOR A PAGAR: R$ {0}", valorT.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}