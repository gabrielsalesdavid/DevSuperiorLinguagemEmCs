using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.Vetores;
internal class VetorEmC_ {

    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;

        int n;

        Console.WriteLine("Quantos numeros voce vai digitar? ");
        n = int.Parse(Console.ReadLine());

        double[] vet = new double[n];
        for (int i = 0; i < n; i++) {
            Console.WriteLine("Digite um numero: ");
            vet[i] = double.Parse(Console.ReadLine(), CI);
        }

        Console.WriteLine();
        Console.WriteLine("Numeros Digitados: ");
        for (int i = 0; i < n; i++) {
            Console.WriteLine(vet[i].ToString("F1", CI));
        }
    }
}