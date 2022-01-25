using System;

namespace CadastroClientesWF
{
    [TableAttribute("enderecos")]
    public class Endereco : Tabela<Endereco>
    {
        [TableAttribute("id_endereco")]
        public Guid Id_endereco { set; get; }

        [TableAttribute("id_cliente")]
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

    }

}
