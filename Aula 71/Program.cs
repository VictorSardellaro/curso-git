using System;

namespace Aula_71 {
    class Program {
        static void Main(string[] args) {

            Hotel[] vect = new Hotel[10];
            
            Console.Write("Quantos quartos serão alugados? ");
            int qtd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= qtd; i++) {

                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                               
                vect[quarto] = new Hotel(nome, email);
            }


            Console.WriteLine("Quartos Ocupados");
            Console.WriteLine();

            for (int i = 0; i < 10; i++) {

                if (vect[i] != null) {

                    Console.WriteLine(i + ": " + vect[i]);

                }


            }
        }
    }
}
