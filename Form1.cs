using System;
using System.Data.SqlClient;
using System.Configuration;
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
    public partial class Form1 : Form
    {
        public static Cliente cliente = new Cliente();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InsereValorCliente();
            cliente.Salvar();
            MessageBox.Show("Cliente cadastrado com sucesso!");
            button2.Visible = true;
            button3.Visible = true;
        }
        private void InsereValorCliente()
        {
            cliente.Id = Guid.NewGuid();
            cliente.Nome = tb_nome.Text;
            cliente.Sobrenome = tb_sobrenome.Text;
            cliente.Nascimento = mtb_dataNasc.Text;
            cliente.EstadoCivil = cb_estCivil.SelectedText;
            cliente._EstadoCivil = cb_estCivil.SelectedIndex;
            cliente.CPF = mtb_cpf.Text;
            cliente.CNPJ = mtb_cnpj.Text;
        }
        private void ResetaCampos()
        {
            tb_nome.Text = "";
            tb_sobrenome.Text = "";
            mtb_dataNasc.Text = "";
            cb_estCivil.SelectedIndex = -1;
            cb_pessoaJurfis.SelectedIndex = -1;
            mtb_cpf.Text = "";
            mtb_cnpj.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ResetaCampos();
            var cadastroEnderecos = new F_CadastroEndereco();
            cadastroEnderecos.Owner = this;
            cadastroEnderecos.Show();
        }
        private void mtb_dataNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtb_dataNasc.Clear();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("6839000");
            item.SubItems.Add("PA, 1");
            lv_enderecos.Items.Add(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lv_enderecos.Visible = true;
            lv_enderecos.Items.Clear();
            Dictionary<string, string> infos = cliente.ResgatarInfo();
            foreach (var info in infos)
            {
                ListViewItem item = new ListViewItem(info.Key);
                string[] subItens = info.Value.Split(',');
                item.SubItems.Add(subItens[1]);
                item.SubItems.Add(subItens[0]);
                lv_enderecos.Items.Add(item);
            }
        }
    }
}
