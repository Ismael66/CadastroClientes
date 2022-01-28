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
    public partial class ListaTodosClientes : Form
    {
        public ListaTodosClientes()
        {
            InitializeComponent();
        }

        private void ListaTodosClientes_Load(object sender, EventArgs e)
        {
            //this.Owner.Close();
            var cliente = new Cliente();
            var infos = cliente.ObterDados();
            foreach (var info in infos)
            {
                ListViewItem item = new ListViewItem(info.Id.ToString());
                item.SubItems.Add(info.Nome);
                item.SubItems.Add(info.Sobrenome);
                item.SubItems.Add(info.Nascimento);
                item.SubItems.Add(info.EstadoCivil);
                item.SubItems.Add(info.CPF);
                item.SubItems.Add(info.CNPJ);
                lv_enderecos.Items.Add(item);
            }
        }
    }
}
