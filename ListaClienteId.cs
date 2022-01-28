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
    public partial class ListaClienteId : Form
    {
        public ListaClienteId()
        {
            InitializeComponent();
        }

        private void lv_enderecos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Owner.Close();
            var cliente = new Cliente();
            if (Guid.TryParse(tb_id.Text, out var NewGuid))
            {
                var idDigitado = Guid.Parse(tb_id.Text);
                var infos = cliente.ObterCliente(idDigitado);
                if (infos.Count > 0)
                {
                    foreach (var info in infos)
                    {
                        ListViewItem item = new ListViewItem(idDigitado.ToString());
                        item.SubItems.Add(info.Nome);
                        item.SubItems.Add(info.Sobrenome);
                        item.SubItems.Add(info.Nascimento);
                        item.SubItems.Add(info.EstadoCivil);
                        item.SubItems.Add(info.CPF);
                        item.SubItems.Add(info.CNPJ);
                        lv_enderecos.Items.Add(item);
                    }
                    lv_enderecos.Visible = true;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado");
                }
            }
            else
            {
                MessageBox.Show("Id invalido");
            }
            
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
