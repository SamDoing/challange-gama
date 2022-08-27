using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone
{
    internal class SalarioPorHora : Salario
    {
        public SalarioPorHora(double salario)
        {
            salarioCalculado = salario / 30 / 8;
            tipo = "hora";
        }
    }
}
