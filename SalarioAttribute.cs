using System;


namespace Stone
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class SalarioAttribute : Attribute
    {
        public string Mensagem { get; private set; }
        public SalarioAttribute(string mensagem)
        {
            Mensagem = mensagem;
        }
    }
}
