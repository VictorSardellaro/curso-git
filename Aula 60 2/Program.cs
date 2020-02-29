using System;
using System.Globalization;

namespace Aula_60 {
    class Program {
        static void Main(string[] args) {

            Conta c;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?: ");
            char r = char.Parse(Console.ReadLine());

            if (r == 's' || r == 'S') {
                Console.Write("Digite o valor iniciar: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, nome, depositoInicial);
            }
            else {
                c = new Conta(numero, nome);
            }

            char resposta = 's';

            while (resposta == 's' || resposta == 'S') { 

            Console.Write("Digite 1 para deposito ou 2 para saque: ");
            int caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch) {

                    case 1:
                        Console.Write("Digite do deposito: ");
                        double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        c.Deposito(deposito);
                        Console.WriteLine("Dados da conta atualizados: ");
                        Console.WriteLine(c);
                        break;

                    case 2:
                        Console.Write("Digite do saque: ");
                        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        c.Saque(saque);
                        Console.WriteLine("Dados da conta atualizados: ");
                        Console.WriteLine(c);
                        break;
                }

                Console.Write("Deseja realizar uma nova operação (s/n)? ");
                resposta = char.Parse(Console.ReadLine());
            }

            Console.Write(c);

        }
    }
}