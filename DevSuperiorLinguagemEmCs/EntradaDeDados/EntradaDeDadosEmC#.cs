using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.EntradaDeDados;
class EntradaDeDadosEmC_ {

    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;

        double salario01, salario02;
        string nome01, nome02;
        int idade;
        char sexo;

        Console.WriteLine("Digite o nome da primeira pessoa: ");
        nome01 = Console.ReadLine();
        Console.WriteLine("Digite o salario da primeira pessoa: ");
        salario01 = double.Parse(Console.ReadLine(), CI);

        Console.WriteLine("Digite o nome da segunda pessoa: ");
        nome02 = Console.ReadLine();
        Console.WriteLine("Digite o salario a segunda pessoa: ");
        salario02 = double.Parse(Console.ReadLine(), CI);

        Console.WriteLine("Digite uma idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um sexo(F/M): ");
        sexo = char.Parse(Console.ReadLine());

        Console.WriteLine("Nome 1 = " + nome01 + ", Salario 1 = " + salario01.ToString("F2", CI));
        Console.WriteLine("Nome 2 = " + nome02 + ", Salario 2 = " + salario02.ToString("F2", CI));
        Console.WriteLine("Idade = " + idade);
        Console.WriteLine("Sexo = " + sexo);

    }
}