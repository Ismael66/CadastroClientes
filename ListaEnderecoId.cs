using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientesWF
{
    public partial class ListaEnderecoId : Form
    {
        public ListaEnderecoId()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var endereco = new Endereco();
            if (Guid.TryParse(tb_id.Text, out var NewGuid))
            {
                var idDigitado = Guid.Parse(tb_id.Text);
                var parametros = new List<string> { "id_endereco", "id_cliente", "cep", "rua", "bairro", "numero", "estado", "pais" };
                var infos = endereco.ObterDados(parametros, idDigitado, "id_endereco");
                if (infos.Count > 0)
                {
                    foreach (var info in infos)
                    {
                        ListViewItem item = new ListViewItem(idDigitado.ToString());
                        item.SubItems.Add(info.Id_cliente.ToString());
                        item.SubItems.Add(info.Cep);
                        item.SubItems.Add(info.Rua);
                        item.SubItems.Add(info.Bairro);
                        item.SubItems.Add(info.Numero);
                        item.SubItems.Add(info.Estado);
                        item.SubItems.Add(info.Pais);
                        lv_enderecos.Items.Add(item);
                    }
                    lv_enderecos.Visible = true;
                }
                else
                {
                    MessageBox.Show("aí é foda");
                }
            }
            else
            {
                MessageBox.Show("Id invalido");
            }

        }

        private void ListaEnderecoId_FormClosed(object sender, FormClosedEventArgs e)
        {
            lv_enderecos.Visible = false;
        }

        private void ListaEnderecoId_Load(object sender, EventArgs e)
        {

        }
    }
}
