using System;
using System.Collections.Generic;
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
            mtb_cnpj.Enabled = false;
            mtb_cpf.Enabled = false;
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
            this.Owner.Enabled = false;
        }
        private void cb_pessoaJurfis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_pessoaJurfis.SelectedIndex == 0)
            {
                mtb_cnpj.Enabled = true;
                mtb_cpf.Enabled = false;
                mtb_cpf.Text = "";
            }
            if (cb_pessoaJurfis.SelectedIndex == 1)
            {
                mtb_cnpj.Enabled = false;
                mtb_cpf.Enabled = true;
                mtb_cnpj.Text = "";
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
