﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.SaidaDeDados;
internal class SaidaDeDadosEmC {

    static void Main(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;

        int idade;
        double salario;
        string nome;
        char sexo;

        idade = 32;
        salario = 4560.9;
        nome = "Maria Silva";
        sexo = 'F';

        Console.WriteLine("A funcionaria " + nome + ", sexo " + sexo + ", ganha " + salario.ToString("F2", CI));
    }
}