using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone
{
    internal class SalarioPorAno : Salario
    {
        public SalarioPorAno(double salario)
        {
            salarioCalculado = salario * 12;
            tipo = "ano";
        }
    }
}
