using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.Problemas;
internal class ProblemaCrescenteEmC_ {

    static void Man(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;

        int num01, num02;

        Console.WriteLine("Digite dois numeros: ");
        num01 = int.Parse(Console.ReadLine());
        num02 = int.Parse(Console.ReadLine());

        do {
            if (num01 < num02) {
                Console.WriteLine("Decrescente!");
            } else {
                Console.WriteLine("Crescente!");
            }
            Console.WriteLine("Digite outros dois numeros: ");
            num01 = int.Parse(Console.ReadLine());
            num02 = int.Parse(Console.ReadLine()); 

        } while (num01 != num02);
    }
}