using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone
{
    [Salario("salario por mes")]
    internal class SalarioMes : Salario
    {
        public SalarioMes(double salario)
        {
            salarioCalculado = salario;
            tipo = "mes";
        }
    }
}
