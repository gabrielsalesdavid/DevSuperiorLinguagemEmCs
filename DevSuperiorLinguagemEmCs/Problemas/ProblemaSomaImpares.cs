using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.Problemas;
internal class ProblemaSomaImpares {

    static void Main(string[] args) {

        int num01, num02, trocaNum, somaImpares;

        Console.WriteLine("Digite dois numeros: ");
        num01 = int.Parse(Console.ReadLine());
        num02 = int.Parse(Console.ReadLine());

        if (num01 > num02) {
            trocaNum = num01;
            num01 = num02;
            num02 = trocaNum;
        }

        somaImpares = 0;
        for (int i = num01 + 1; i < num02; i++) {
           if (i % 2 != 0) {
                somaImpares = somaImpares + i;
            }
        }

        Console.WriteLine("Soma dos impares = " + somaImpares);
    }
}