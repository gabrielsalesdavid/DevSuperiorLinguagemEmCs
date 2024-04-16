using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.EstruturaDeControle;
class EstruturaDeRepeticaoParaEmC_ {
    
    static void Main(string[] args) {

        int n, i, x, soma;

        Console.WriteLine("QUantos numeros serao digitados? ");
        n = int.Parse(Console.ReadLine());

        soma = 0;
        for (i = 0; i < n; i++) {
            Console.WriteLine("Digite um numero: ");
            x = int.Parse(Console.ReadLine());
            soma = soma + x;
        }

        Console.WriteLine("Soma = " + soma);
    }
}