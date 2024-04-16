using System;
using System.Globalization;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.Problemas;
internal class ProblemaMenorDeTresEmC_ {

    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;

        int num01, num02, num03, menorDeTres;

        Console.WriteLine("Primeiro valor: ");
        num01 = int.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor: ");
        num02 = int.Parse(Console.ReadLine());
        Console.WriteLine("Terceiro valor: ");
        num03 = int.Parse(Console.ReadLine());

        if (num01 > num02 && num01 > num03) {
            menorDeTres = num01;
        } else if (num02 > num03) {
            menorDeTres = num02;
        } else {
            menorDeTres = num03;
        }

        Console.WriteLine("Menor = " + menorDeTres);
    }
}