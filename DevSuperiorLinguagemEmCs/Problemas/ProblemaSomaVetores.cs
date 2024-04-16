using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.Problemas;
internal class ProblemaSomaVetores {

    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;

        int n;
        double soma, media;

        Console.WriteLine("Quantos numeros voce vai digitar? ");
        n = int.Parse(Console.ReadLine());

        double[] vet = new double[n];
        for (int i = 0; i < n; i++) {
            Console.WriteLine("Digite um numero: ");
            vet[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Valores = ");
        for (int i = 0; i < n; i++) {
            Console.Write(vet[i] + " ");
        }
        Console.WriteLine();

        soma = 0;
        for (int i = 0; i < n; i++) {
           soma = soma + vet[i];
        }

        Console.WriteLine("Soma = " + soma.ToString("F2", CI));

        media = soma / n;
        Console.WriteLine("Media = " + media.ToString("F2", CI));
    }
}