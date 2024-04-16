using System;
using System.Globalization;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.Matriz;
internal class MatrizEmC_ {

    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;

        int m, n;

        Console.WriteLine("Quantas linhas vai ter a matriz? ");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("Quantas colunas vai ter a matriz? ");
        n = int.Parse(Console.ReadLine());

        int[,] mat = new int[m, n];
        for (int i = 0; i < m; i++) {
           for (int j = 0; j < n; j++) {
                Console.WriteLine("Elemento [" + i + ", " + j + "]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Matriz digitada: ");
        for (int i = 0; i < m; i++) {
           for (int j = 0; j < n; j++) {
                Console.WriteLine(mat[i, j] + " ");
            }
        }
    }
}