using System;

namespace Aula_27 {
    class Program {
        static void Main(string[] args) {

            int x = 0;
            int c = 0;

            while (c == 0) {

                Console.WriteLine("Digite um número inteiro: ");
                x = int.Parse(Console.ReadLine());

                if (x / 2 == 0) {
                    Console.Clear();
                    Console.WriteLine("O número "+ x +" é Par!\n");
                    Console.ReadKey();
                }
                else {
                    Console.Clear();
                    Console.WriteLine("O número " + x + " é Impar!\n");
                    Console.ReadKey();
                }
                Console.Clear();

                Console.WriteLine("Digite 0 para continuar ou 1 para parar");
                c = int.Parse(Console.ReadLine());

                Console.Clear();
            }
        }
    }
}
