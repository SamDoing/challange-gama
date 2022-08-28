using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone
{
    [Salario("salario por semana")]
    internal class SalarioSemana : Salario
    {
        public SalarioSemana(double salario)
        {
            salarioCalculado = salario/30*7;
            tipo = "semana";
        }
    }
}
