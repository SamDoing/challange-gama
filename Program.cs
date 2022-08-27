using System;
using System.Linq;
using System.Reflection;

namespace Stone
{
    internal class Program
    {
        static int Main()
        {
            double salarioValor = GetSalario();

            var salario = (Salario) Activator.CreateInstance(GetOpcaoTipo(), salarioValor);
            
            salario.Imprime();
            
            Console.ReadKey();
            return 0;
        }

        static Type GetOpcaoTipo()
        {
            var salarios = Assembly.GetExecutingAssembly().GetTypes().Where( t => typeof(Salario).IsAssignableFrom(t) && t != typeof(Salario) );
            Type salarioTipo = null;

            while(salarioTipo == null)            
            {
                Console.WriteLine("--------Opcoes-------");

                foreach (var salario in salarios.Select( (t, i) => new { index = i, nome = t.Name } ))
                    Console.WriteLine($"{salario.index} - {salario.nome.SplitCamelCase().ToLower()}");

                Console.Write("Opcao: ");
                
                
                if(!int.TryParse(Console.ReadLine(), out int index)) continue;

                salarioTipo = salarios.ElementAtOrDefault(index);
            }
            return salarioTipo;
        }

        static double GetSalario()
        {
            Console.Write("Quanto o funcionario ganha por mes: ");
            double salario = 0;
            try
            {
                salario = Double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine($"O salario possui um formato invalido!");
                Console.ReadKey();
                GetSalario();
            }
            return salario;
        }
    }
}
