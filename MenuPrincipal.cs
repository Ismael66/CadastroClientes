using System;
using System.Windows.Forms;

namespace CadastroClientesWF
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //var teste = new Endereco() { Bairro = "123", Rua =  "456" };
            //MessageBox.Show($"{teste}");
            //Console.WriteLine(teste);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.Size = new System.Drawing.Size(140, 140);
            lb_cadastro_cliente.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Size = new System.Drawing.Size(100, 100);
            lb_cadastro_cliente.Visible = false;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.Size = new System.Drawing.Size(140, 140);
            lb_lista_cliente.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Size = new System.Drawing.Size(100, 100);
            lb_lista_cliente.Visible = false;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.Size = new System.Drawing.Size(140, 140);
            lb_cadastro_ende.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.Size = new System.Drawing.Size(100, 100);
            lb_cadastro_ende.Visible = false;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel4.Size = new System.Drawing.Size(140, 140);
            lb_lista_ende.Visible = true;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.Size = new System.Drawing.Size(100, 100);
            lb_lista_ende.Visible = false;
        }

        private void lb_lista_cliente_Click(object sender, EventArgs e)
        {

        }

        private void lb_cadastro_ende_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var cadastroClientes = new Form1();
            cadastroClientes.Owner = this;
            cadastroClientes.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            var cadastroEnderecos = new F_CadastroEndereco();
            cadastroEnderecos.Owner = this;
            cadastroEnderecos.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            var listaClientes = new ListaClientes();
            listaClientes.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            var listaEnderecos = new ListaEnderecos();
            listaEnderecos.Show();
        }
    }
}
