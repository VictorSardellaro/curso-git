using System;

namespace primeirosExercicios01 {
    class Program {

        static void Main(string[] args) {

            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite o nome e em seguida a idade: ");
            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome e em seguida a idade: ");
            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade) {
                Console.WriteLine(p1.Nome + " é mais velha que " + p2.Nome);
            }
            else if(p1.Idade < p2.Idade) {
                Console.WriteLine(p2.Nome + " é mais velha que " + p1.Nome);
            }
            else {
                Console.WriteLine("Ambos possuem a mesma idade");

            }
        }

        

    }
}
