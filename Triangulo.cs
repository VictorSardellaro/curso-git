﻿using System;

namespace Aula_40 {
    class Triangulo {

        public double A;
        public double B;
        public double C;

        public double Area(){
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p* (p - A)*(p - B)*(p - c));
        }
    }
}
