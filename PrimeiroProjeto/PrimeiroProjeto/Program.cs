using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class Program {
        static void Main(string[] args) {

            int numero, horas;
            double valorHora, salario;

            Console.WriteLine("Digite o numero do funcionario: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da hora: ");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valorHora;

            Console.WriteLine("Number " + numero);           
            Console.WriteLine("O funcionario de numero " + numero + " Deve receber o total de: " + salario.ToString("F3", CultureInfo.InvariantCulture));

     
        }
    }
}
