using System;
using System.Globalization;

namespace Aula_45_Ex_01 {
    class Program {
        static void Main(string[] args) {
                        
            Retangulo r = new Retangulo();
           

            Console.Write("Entre com a Largura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com a Altura do retângulo: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write(r);
            Console.WriteLine();
           
        }
    }
}
