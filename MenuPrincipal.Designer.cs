namespace CadastroClientesWF
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lb_cadastro_cliente = new System.Windows.Forms.Label();
            this.lb_lista_cliente = new System.Windows.Forms.Label();
            this.lb_cadastro_ende = new System.Windows.Forms.Label();
            this.lb_lista_ende = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_cadastro_cliente
            // 
            this.lb_cadastro_cliente.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cadastro_cliente.Location = new System.Drawing.Point(129, 365);
            this.lb_cadastro_cliente.Name = "lb_cadastro_cliente";
            this.lb_cadastro_cliente.Size = new System.Drawing.Size(117, 50);
            this.lb_cadastro_cliente.TabIndex = 2;
            this.lb_cadastro_cliente.Text = "Cadastrar novo usuário";
            this.lb_cadastro_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_cadastro_cliente.Visible = false;
            // 
            // lb_lista_cliente
            // 
            this.lb_lista_cliente.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lista_cliente.Location = new System.Drawing.Point(281, 356);
            this.lb_lista_cliente.Name = "lb_lista_cliente";
            this.lb_lista_cliente.Size = new System.Drawing.Size(117, 50);
            this.lb_lista_cliente.TabIndex = 3;
            this.lb_lista_cliente.Text = "Listar usuários";
            this.lb_lista_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_lista_cliente.Visible = false;
            this.lb_lista_cliente.Click += new System.EventHandler(this.lb_lista_cliente_Click);
            // 
            // lb_cadastro_ende
            // 
            this.lb_cadastro_ende.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cadastro_ende.Location = new System.Drawing.Point(442, 365);
            this.lb_cadastro_ende.Name = "lb_cadastro_ende";
            this.lb_cadastro_ende.Size = new System.Drawing.Size(117, 50);
            this.lb_cadastro_ende.TabIndex = 4;
            this.lb_cadastro_ende.Text = "Cadastrar novo endereço";
            this.lb_cadastro_ende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_cadastro_ende.Visible = false;
            this.lb_cadastro_ende.Click += new System.EventHandler(this.lb_cadastro_ende_Click);
            // 
            // lb_lista_ende
            // 
            this.lb_lista_ende.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lista_ende.Location = new System.Drawing.Point(598, 356);
            this.lb_lista_ende.Name = "lb_lista_ende";
            this.lb_lista_ende.Size = new System.Drawing.Size(117, 50);
            this.lb_lista_ende.TabIndex = 5;
            this.lb_lista_ende.Text = "Listar endereços";
            this.lb_lista_ende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_lista_ende.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.BackgroundImage = global::CadastroClientesWF.Properties.Resources.My_project_4_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(429, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 100);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            this.panel3.MouseHover += new System.EventHandler(this.panel3_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::CadastroClientesWF.Properties.Resources.add_user__1__3_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(588, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 100);
            this.panel4.TabIndex = 1;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.panel4.MouseHover += new System.EventHandler(this.panel4_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.BackgroundImage = global::CadastroClientesWF.Properties.Resources.add_user__1__2_1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(268, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel2.MouseHover += new System.EventHandler(this.panel2_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImage = global::CadastroClientesWF.Properties.Resources.add_user__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(121, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.lb_lista_ende);
            this.Controls.Add(this.lb_cadastro_ende);
            this.Controls.Add(this.lb_lista_cliente);
            this.Controls.Add(this.lb_cadastro_cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_cadastro_cliente;
        private System.Windows.Forms.Label lb_lista_cliente;
        private System.Windows.Forms.Label lb_cadastro_ende;
        private System.Windows.Forms.Label lb_lista_ende;
    }
}