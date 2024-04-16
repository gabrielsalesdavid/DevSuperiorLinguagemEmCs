using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.Problemas;
internal class ProblemaRetanguloEmC_ {

    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;

        double largura, altura, area, perimetro, diagonal;

        Console.WriteLine("Base do retangulo: ");
        largura = double.Parse(Console.ReadLine(), CI);
        Console.WriteLine("Altura do retangulo: ");
        altura = double.Parse(Console.ReadLine(), CI);

        area = largura * altura;
        perimetro = 2 * (largura + altura);
        diagonal = Math.Sqrt(Math.Pow(largura, 2.0) + Math.Pow(altura, 2.0));

        Console.WriteLine("Area = " + area.ToString("F4", CI));
        Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CI));
        Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CI));
    }
}