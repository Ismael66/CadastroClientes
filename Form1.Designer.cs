namespace CadastroClientesWF
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_estCivil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_pessoaJurfis = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mtb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.mtb_dataNasc = new System.Windows.Forms.MaskedTextBox();
            this.tb_sobrenome = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lv_enderecos = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sobrenome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de nascimento:";
            // 
            // cb_estCivil
            // 
            this.cb_estCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estCivil.FormattingEnabled = true;
            this.cb_estCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Separado",
            "Divorciado",
            "Viúvo"});
            this.cb_estCivil.Location = new System.Drawing.Point(6, 252);
            this.cb_estCivil.Name = "cb_estCivil";
            this.cb_estCivil.Size = new System.Drawing.Size(162, 21);
            this.cb_estCivil.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(3, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado cívil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(1, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pessoa:";
            // 
            // cb_pessoaJurfis
            // 
            this.cb_pessoaJurfis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pessoaJurfis.FormattingEnabled = true;
            this.cb_pessoaJurfis.Items.AddRange(new object[] {
            "Jurídica",
            "Física"});
            this.cb_pessoaJurfis.Location = new System.Drawing.Point(6, 315);
            this.cb_pessoaJurfis.Name = "cb_pessoaJurfis";
            this.cb_pessoaJurfis.Size = new System.Drawing.Size(162, 21);
            this.cb_pessoaJurfis.TabIndex = 11;
            this.cb_pessoaJurfis.SelectedIndexChanged += new System.EventHandler(this.cb_pessoaJurfis_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(1, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cpf:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(1, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cnpj:";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Enabled = false;
            this.mtb_cpf.Location = new System.Drawing.Point(6, 376);
            this.mtb_cpf.Mask = "000.000.000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(162, 20);
            this.mtb_cpf.TabIndex = 16;
            this.mtb_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtb_cnpj
            // 
            this.mtb_cnpj.Enabled = false;
            this.mtb_cnpj.Location = new System.Drawing.Point(7, 438);
            this.mtb_cnpj.Mask = "00.000.000/0000-00";
            this.mtb_cnpj.Name = "mtb_cnpj";
            this.mtb_cnpj.Size = new System.Drawing.Size(162, 20);
            this.mtb_cnpj.TabIndex = 17;
            this.mtb_cnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtb_dataNasc
            // 
            this.mtb_dataNasc.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtb_dataNasc.Location = new System.Drawing.Point(6, 188);
            this.mtb_dataNasc.Mask = "00/00/0000";
            this.mtb_dataNasc.Name = "mtb_dataNasc";
            this.mtb_dataNasc.Size = new System.Drawing.Size(162, 20);
            this.mtb_dataNasc.TabIndex = 18;
            this.mtb_dataNasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtb_dataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // tb_sobrenome
            // 
            this.tb_sobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sobrenome.Location = new System.Drawing.Point(6, 125);
            this.tb_sobrenome.Name = "tb_sobrenome";
            this.tb_sobrenome.Size = new System.Drawing.Size(162, 20);
            this.tb_sobrenome.TabIndex = 5;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(6, 68);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(162, 20);
            this.tb_nome.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(277, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 30);
            this.button1.TabIndex = 33;
            this.button1.Text = "Registrar cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(543, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 30);
            this.button2.TabIndex = 34;
            this.button2.Text = "Registrar endereços do cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lv_enderecos
            // 
            this.lv_enderecos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.lv_enderecos.HideSelection = false;
            this.lv_enderecos.Location = new System.Drawing.Point(543, 323);
            this.lv_enderecos.Name = "lv_enderecos";
            this.lv_enderecos.Size = new System.Drawing.Size(215, 112);
            this.lv_enderecos.TabIndex = 35;
            this.lv_enderecos.UseCompatibleStateImageBehavior = false;
            this.lv_enderecos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CEP";
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 2;
            this.columnHeader4.Text = "Bairro";
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "Estado";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(543, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 30);
            this.button3.TabIndex = 36;
            this.button3.Text = "Mostrar endereços registrados\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroClientesWF.Properties.Resources.Super_Mário;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lv_enderecos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtb_dataNasc);
            this.Controls.Add(this.mtb_cnpj);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_pessoaJurfis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_estCivil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_sobrenome);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_estCivil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_pessoaJurfis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.MaskedTextBox mtb_cnpj;
        private System.Windows.Forms.MaskedTextBox mtb_dataNasc;
        private System.Windows.Forms.TextBox tb_sobrenome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lv_enderecos;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button3;
    }
}

