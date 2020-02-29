using System;
using System.Globalization;

namespace Aula_42 {
    class Program {
        static void Main(string[] args) {

            Product p = new Product();


            Console.WriteLine("Entre os dados do produto");

            Console.Write("Nome: ");
            p.Name = Console.ReadLine();

            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Qty = int.Parse(Console.ReadLine());
            
                    

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AddProducts(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("Digite o número de produtos a ser removido no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemProducts(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


        }
    }
}
