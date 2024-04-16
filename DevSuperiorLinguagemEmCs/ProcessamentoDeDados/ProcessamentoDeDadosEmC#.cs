using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSuperiorLinguagemEmCs.ProcessamentoDeDados;
class ProcessamentoDeDadosEmC_ {

    static void Mian(string[] args) {

        CultureInfo CI = CultureInfo.InvariantCulture;

        double b1, b2, h, area;
        b1 = 6.0;
        b2 = 8.0;
        h = 5.0;
        area = (double) (b1 + b2) / 2;

        Console.WriteLine(area.ToString("F2", CI));
    }
}