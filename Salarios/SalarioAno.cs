using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone
{
    [Salario("salario por ano")]
    internal class SalarioAno : Salario
    {
        public SalarioAno(double salario)
        {
            salarioCalculado = salario * 12;
            tipo = "ano";
        }
    }
}
