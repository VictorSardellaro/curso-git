using System;
using System.Globalization;

namespace Aula_45_Ex_01 {
    class Retangulo {

        public double Largura;
        public double Altura;

        public  double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return (Largura + Altura) * 2;
        }

        public double Diagonal() {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString() {
            return "A Area do retângulo é: "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\n O perimetro do retângulo é: "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\n A Diagonal do retângulo é: "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
