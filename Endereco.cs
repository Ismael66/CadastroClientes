using System;
using System.Collections.Generic;

namespace CadastroClientesWF
{
    [TableAttribute("enderecos")]
    public class Endereco : Tabela<Endereco>
    {
        public Endereco()
        {
        }

        [TableAttribute("id_endereco")]
        public override Guid Id { set; get; }

        [TableAttribute("id_cliente")]
        [TableAttribute(IdLigacao = true)]
        public Guid Id_cliente { set; get; }

        [TableAttribute("cep")]
        public string Cep { set; get; }

        [TableAttribute("rua")]
        [TableAttribute(Requirido = true)]
        public string Rua { get; set; }

        [TableAttribute("bairro")]
        [TableAttribute(Requirido = true)]
        public string Bairro { get; set; }

        [TableAttribute("numero")]
        [TableAttribute(Requirido = true)]
        public string Numero { get; set; }

        [TableAttribute("estado")]
        [TableAttribute(Requirido = true)]
        public string Estado { get; set; }

        [TableAttribute("pais")]
        [TableAttribute(Requirido = true)]
        public string Pais { get; set; }

        public override string ToString()
        {
            return $"Bairro: {this.Bairro}\nRua: {this.Rua}";
        }
        public List<Endereco> ObterEnderecos (Guid id, string campoVinculado)
        {
            var parametros = new List<string> { "id_endereco", "id_cliente", "cep", "rua", "bairro", "numero", "estado", "pais" };
            return this.ObterDados(parametros, id, campoVinculado);
        }
    }

}
