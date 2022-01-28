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
    public partial class ListaEnderecos : Form
    {
        public ListaEnderecos()
        {
            InitializeComponent();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            var listaTodosEnderecos = new ListaTodosEnderecos{ Owner = this };
            listaTodosEnderecos.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var listaEnderecoId = new ListaEnderecoId { Owner = this };
            listaEnderecoId.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            var listaEnderecosIdCliente = new ListaEnderecosIdCliente { Owner = this };
            listaEnderecosIdCliente.Show();
        }
    }
}
