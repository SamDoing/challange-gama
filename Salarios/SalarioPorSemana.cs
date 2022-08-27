using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone
{
    internal class SalarioPorSemana : Salario
    {
        public SalarioPorSemana(double salario)
        {
            salarioCalculado = salario/30*7;
            tipo = "semana";
        }
    }
}
