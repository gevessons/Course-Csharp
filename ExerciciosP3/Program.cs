using System;

namespace Exercicio3 {
    public static class Exercicio {
        public static void Main(String[] args) {
            
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int diferenca = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = {0}", diferenca);

        }
    }
}