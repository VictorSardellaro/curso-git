using System;
using System.Globalization;

namespace Aula_60 {
    class Program {
        static void Main(string[] args) {
            Conta c = new Conta(1234, "Victor", 500.00);
            
            Console.Write("Entre com o numero da conta: ");
            c.Numero = int.Parse(Console.ReadLine()); 

            Console.Write("Entre com o nome do titular: ");
            c.Nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?: ");
            string r = Console.ReadLine();

            if (r == "s") {
                Console.Write("Digite o valor iniciar: ");
                c.Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else {
                c.Saldo = 0.00;
            }

            Console.Write("Digite 1 para deposito ou 2 para saque: ");
            int caseSwitch = int.Parse(Console.ReadLine());

            switch (caseSwitch){

            case 1:
                Console.Write("Digite do deposito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    c.Deposito(deposito);
                    break;
            
            case 2:
                Console.Write("Digite do saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    c.Saque(saque);
                    break;
            }
            
            Console.Write(c);

        }
    }
}
