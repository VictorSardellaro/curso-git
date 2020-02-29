using System;

namespace Aula_81 {
    class Program {
        static void Main(string[] args) {

            int colu = int.Parse(Console.ReadLine());
            int linh = int.Parse(Console.ReadLine());


            int[,] mat = new int[colu, linh];


            for (int i = 0; i < colu; i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < linh; j++) {
                    mat[i, j] = int.Parse(values[j]);

                }

            }

            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < colu; i++) {
                for (int j = 0; j < linh; j++) {
                    if (mat[i, j] == valor) {

                        Console.WriteLine("Position: " + i + ", " + j + ":" );

                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[(i-1), j] );

                        }
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, (j-1)]);

                        }
                        if (j < linh - 1) {
                            Console.WriteLine("Right: " + mat[i, (j+1)]);

                        }
                        if (i < colu -1) {
                            Console.WriteLine("Down: " + mat[(i+1), j]);

                        }

                    }
                }

            }

        }
    }
}
