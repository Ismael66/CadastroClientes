using System;
using System.Collections.Generic;

namespace CadastroClientesWF
{
    [TableAttribute("clientes")]
    public class Cliente : Tabela<Cliente>
    {
        [TableAttribute(IdLigacao = true)]
        [TableAttribute("id")]
        public override Guid Id { get; set; }

        [TableAttribute("nome")]
        [TableAttribute(Requirido =true)]
        public string Nome { set; get; }

        [TableAttribute("sobrenome")]
        [TableAttribute(Requirido = true)]
        public string Sobrenome { get; set; }

        [TableAttribute("nascimento")]
        [TableAttribute(Requirido = true)]
        public string Nascimento { get; set; }

        [TableAttribute("estado_civil")]
        [TableAttribute(Requirido = true)]
        public int _EstadoCivil { get; set; }

        [TableAttribute(NaoLevar = true)]
        public string EstadoCivil { get; set; }

        [TableAttribute("cpf")]
        public string CPF { get; set; }

        [TableAttribute("cnpj")]
        public string CNPJ { get; set; }
        public List<Cliente> ObterCliente(Guid id)
        {
            return this.ObterDados(new List<string> { "nome", "sobrenome", "nascimento", "cpf", "cnpj" }, id, "id");
        }
    }
    
}
