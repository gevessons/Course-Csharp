using System;
using System.Globalization;

namespace Course {
    public static class Program {
        public static void Main(string[] args) {

            //Entrada de dados 2

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] v = Console.ReadLine().Split(' ');

            string nome = v[0];
            char sexo  = char.Parse(v[1]);
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture);


            Console.WriteLine("n1: " + n1);
            Console.WriteLine("ch: " + ch);
            Console.WriteLine("n2: " + n2);

            Console.WriteLine("nome: " + nome);
            Console.WriteLine("sexo: " + sexo);
            Console.WriteLine("idade: " + idade);
            Console.WriteLine("altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}