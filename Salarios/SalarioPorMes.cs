using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone
{
    internal class SalarioPorMes : Salario
    {
        public SalarioPorMes(double salario)
        {
            salarioCalculado = salario;
            tipo = "mes";
        }
    }
}
