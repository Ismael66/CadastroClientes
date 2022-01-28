using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientesWF
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
    internal class TableAttribute : Attribute
    {
        public string Nome;
        public bool NaoLevar;
        public bool Requirido;
        public bool IdLigacao;

        public TableAttribute(string nome)
        {
            Nome = nome;
        }
        public TableAttribute()
        {

        }
    }
}
