using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone
{
    [Salario("salario por hora")]
    internal class SalarioHora : Salario
    {
        public SalarioHora(double salario)
        {
            salarioCalculado = salario / 30 / 8;
            tipo = "hora";
        }
    }
}
