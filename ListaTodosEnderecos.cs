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
    public partial class ListaTodosEnderecos : Form
    {
        public ListaTodosEnderecos()
        {
            InitializeComponent();
        }

        private void ListaTodosEnderecos_Load(object sender, EventArgs e)
        {
            var endereco = new Endereco();
            var infos = endereco.ObterDados();
            foreach (var info in infos)
            {
                ListViewItem item = new ListViewItem(info.Id.ToString());
                item.SubItems.Add(info.Id_cliente.ToString());
                item.SubItems.Add(info.Cep);
                item.SubItems.Add(info.Rua);
                item.SubItems.Add(info.Bairro);
                item.SubItems.Add(info.Numero);
                item.SubItems.Add(info.Estado);
                item.SubItems.Add(info.Pais);
                lv_enderecos.Items.Add(item);
            }
        }

        private void lv_enderecos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
