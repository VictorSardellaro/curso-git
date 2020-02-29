﻿using System;
using System.Globalization;

namespace Aula_69 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0 ; i < n; i++) {

                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            double sum = 0.0;

            for (int i = 0; i < n; i++) {

                sum += vect[i];
            }

            double avg = sum / n;

            Console.Write("A media é: " + avg.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
