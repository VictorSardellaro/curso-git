using System;
using System.Globalization;

namespace Aula_45_Ex_03 {
    class Aluno {

        public string Nome;
        public double N1, N2, N3;



        public double NotaFinal() {
            return N1 + N2 + N3;
        }

        public bool Aprovado() {
            if (NotaFinal() >= 60.0) {
                return true;
            }

            else {
                return false;
            }
        }
        public double NotaRestante() {
            if (Aprovado()) {
                return 0.0;
            }
            else {
                return 60.0 - NotaFinal();

            }
        }
    }
}
