using System;
using System.Globalization;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.Problemas;
internal class ProblemaIdadeEmC_ {

    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;

        string nome01, nome02;
        int idade01, idade02;
        double media;

        Console.WriteLine("Dados da primeira pessoa: ");
        Console.WriteLine("Nome: ");
        nome01 = Console.ReadLine();
        Console.WriteLine("Idade: ");
        idade01 = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados da segundo pessoa: ");
        Console.WriteLine("Nome: ");
        nome02 = Console.ReadLine();
        Console.WriteLine("Idade: ");
        idade02 = int.Parse(Console.ReadLine());

        media = (idade01 + idade02) / 2.0;

        Console.WriteLine("A idade de " + nome01
                                        + " e "
                                        + nome02
                                        + " eh de "
                                        + media.ToString("F1", CI)
                                        + " anos");
    }
}