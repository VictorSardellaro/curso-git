using System;
using System.Globalization;

namespace Aula_32 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0) {
                                
                double resultado = raiz(x);
                Console.WriteLine("Raiz: " + resultado.ToString("F3", CultureInfo.InvariantCulture));

                Console.ReadKey();

                Console.WriteLine("Digite outro numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            Console.WriteLine("Número negativo!");
        }
        static double raiz(double r1) {

            double raiz = Math.Sqrt(r1);

            return raiz;
        }

    }
}
