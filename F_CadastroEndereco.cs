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
    public partial class F_CadastroEndereco : Form
    {
        public static Endereco endereco = new Endereco();
        public F_CadastroEndereco()
        {
            InitializeComponent();
        }
        private void F_CadastroEndereco_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }
        private void F_CadastroEndereco_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
        private void InsereValorEndereco()
        {
            endereco.Id_endereco = Guid.NewGuid();
            endereco.Id_cliente = Form1.cliente.Id;
            endereco.Cep = mtb_cep.Text;
            endereco.Rua = tb_rua.Text;
            endereco.Bairro = tb_bairro.Text;
            endereco.Numero =  tb_num.Text;
            endereco.Estado = tb_estado.Text;
            endereco.Pais = tb_pais.Text;
        }
        private void ResetaCampos()
        {
            mtb_cep.Text = "";
            tb_rua.Text = "";
            tb_bairro.Text = "";
            tb_num.Text = "";
            tb_estado.Text = "";
            tb_pais.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InsereValorEndereco();
            endereco.Salvar();
            MessageBox.Show("Endereço cadastrado com sucesso!");
            ResetaCampos();
            bt_RegistraNovoCliente.Visible = true;
        }
        private void bt_RegistraNovoCliente_Click(object sender, EventArgs e)
        {
            bt_RegistraNovoCliente.Visible = false;
            this.Close();
        }
        private async void mtb_cep_Leave_1(object sender, EventArgs e)
        {
            if (mtb_cep.Text.Length == 8)
            {
                ViaCep campo = await ApiViaCEP.ConsultarCep(mtb_cep.Text);
                tb_estado.Text = campo.UF;
                tb_rua.Text = campo.Logradouro;
                tb_bairro.Text = campo.Bairro;
            }
        }
    }
}
