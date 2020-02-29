using System;
using System.Globalization;

namespace Aula_45_Ex_02 {
    class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();

            
            Console.Write("Digite o nome do funcionário: ");
            f.Nome = Console.ReadLine();

            Console.Write("Digite o salário bruto do funcionário: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor do imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do funcionario: " + f);
            
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}
