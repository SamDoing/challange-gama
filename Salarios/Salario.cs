using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone
{
    internal abstract class Salario
    {
        protected double salarioCalculado;
        protected string tipo;
        public void Imprime() =>
            Console.WriteLine($"O salario do funcionario por {tipo} e: {salarioCalculado.ToString("F2").Replace('.', ',')}R$");

    }
}
