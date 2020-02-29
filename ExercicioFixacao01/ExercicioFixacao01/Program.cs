using System;
using System.Globalization;

namespace ExercicioFixacao01 {
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine("{0}, cujo preço é ${1:F2} \n{2}, cujo preço é ${3:F2}", produto1, preco1, produto2, preco2);

            Console.WriteLine($"Registro: {idade} anos de idade, Código {codigo} e gênero: {genero}");

            Console.WriteLine("Medida com oito casa decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            
        }
    }
}
