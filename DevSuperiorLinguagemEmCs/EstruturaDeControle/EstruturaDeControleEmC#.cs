using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.EstruturaDeControle;
internal class EstruturaDeControleEmC_ {

    static void Main(string[] args) {

        int hora;

        Console.WriteLine("Digite uma hora do dia: ");
        hora = int.Parse(Console.ReadLine());

        if (hora < 12) {
            Console.WriteLine("Bom dia!");
        } else if (hora > 13) {
            Console.WriteLine("Boa tarde!");
        }
    }
}