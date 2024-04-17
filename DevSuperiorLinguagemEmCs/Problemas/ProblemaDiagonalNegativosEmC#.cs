using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.Problemas;
internal class ProblemaDiagonalNegativos {

    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;

        int n, somaNegativos;

        Console.WriteLine("Qual a ordem da matriz? ");
        n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n,n];
        for (int i = 0; i < n; i++) {
           for (int j = 0; j < n; j++) {
                Console.Write("Elemento [" + i + ", " + j + "]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();
        Console.WriteLine("Diagonal principal: ");
        for (int i = 0; i < n; i++) {
            Console.Write(mat[i, i] + " ");
        }

        Console.WriteLine();
        somaNegativos = 0;
        for (int i = 0; i < n; i++) {
           for (int j = 0; j < n; j++) {
              if (mat[i, j] < 0) {
                    somaNegativos++;
                }
            }


            Console.WriteLine("Quantidade de negativos = " + somaNegativos);
        }
    }
}