using System;
using System.Globalization;

namespace Aula_23 {
    class Program {
        static void Main(string[] args) {

            string nomeCompleto;
            int quarto;
            double preco;

            /* int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            Console.WriteLine("Digite o nome \ndigite M ou F para o sexo \nDigite a idade \nDigite a altura ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse (vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.Clear();

            Console.WriteLine("Nome: "+ nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: "+ idade);
            Console.WriteLine("Altura: "+ altura.ToString("F2", CultureInfo.InvariantCulture)); */

            Console.WriteLine("Entre com seu nome completo");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto");
            preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Clear();
            
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.Clear();

            Console.WriteLine("Nome Completo: " + nomeCompleto + "\nQuantidade de quartos: " + quarto + "\nPreço: R$" + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Ultimo nome: " + nome + "\nIdade: " + idade + "\nAltura: " + altura.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
