using System;
using System.Globalization;

namespace Course {
    public static class Program {
        public static void Main(string[] args) {
            /*
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);*/

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');


            /*Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            */
            Console.WriteLine(vet[0]);
            Console.WriteLine(int.Parse(vet[1]));
            Console.WriteLine(double.Parse(vet[2]).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}