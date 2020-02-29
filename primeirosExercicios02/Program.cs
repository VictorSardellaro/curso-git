using System;
using System.Globalization;

namespace primeirosExercicios02 {
    class Program {
        static void Main(string[] args) {

            double media;

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Entre com o Nome e o Salario do primeiro funcionario: ");
            f1.Nome = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o Nome e o Salario do segundo funcionario: ");
            f2.Nome = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            media = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("A Media dos Salarios é: " + media.ToString("F2",CultureInfo.InvariantCulture));
            
        }
    }
}
