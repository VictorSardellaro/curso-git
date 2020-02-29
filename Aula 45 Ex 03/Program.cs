using System;
using System.Globalization;

namespace Aula_45_Ex_03 {
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.WriteLine("Entre os dados do Aluno");

            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Nota 01: ");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 02: ");
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 03: ");
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");

            }
        }
    }
}
