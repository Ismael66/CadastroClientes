namespace CadastroClientesWF
{
    partial class F_CadastroEndereco
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
            this.tb_pais = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_rua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_pais
            // 
            this.tb_pais.Location = new System.Drawing.Point(14, 419);
            this.tb_pais.MaxLength = 2;
            this.tb_pais.Name = "tb_pais";
            this.tb_pais.Size = new System.Drawing.Size(162, 20);
            this.tb_pais.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(11, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 25);
            this.label15.TabIndex = 44;
            this.label15.Text = "País:";
            // 
            // tb_estado
            // 
            this.tb_estado.Location = new System.Drawing.Point(14, 357);
            this.tb_estado.MaxLength = 2;
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(162, 20);
            this.tb_estado.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(11, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 25);
            this.label14.TabIndex = 42;
            this.label14.Text = "Estado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(11, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 25);
            this.label13.TabIndex = 40;
            this.label13.Text = "N°:";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(14, 233);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(162, 20);
            this.tb_bairro.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(11, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "Bairro:";
            // 
            // mtb_cep
            // 
            this.mtb_cep.Location = new System.Drawing.Point(14, 106);
            this.mtb_cep.Mask = "00000-000";
            this.mtb_cep.Name = "mtb_cep";
            this.mtb_cep.Size = new System.Drawing.Size(162, 20);
            this.mtb_cep.TabIndex = 37;
            this.mtb_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtb_cep.Leave += new System.EventHandler(this.mtb_cep_Leave_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(9, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Rua:";
            // 
            // tb_rua
            // 
            this.tb_rua.Location = new System.Drawing.Point(14, 169);
            this.tb_rua.Name = "tb_rua";
            this.tb_rua.Size = new System.Drawing.Size(162, 20);
            this.tb_rua.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(12, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "Cep:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 28);
            this.button1.TabIndex = 47;
            this.button1.Text = "Registrar endereço";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(14, 296);
            this.tb_num.MaxLength = 5;
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(162, 20);
            this.tb_num.TabIndex = 41;
            // 
            // F_CadastroEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CadastroClientesWF.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_pais);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_estado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_bairro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mtb_cep);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_rua);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CadastroEndereco";
            this.Text = "Cadastro de Endereço";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_CadastroEndereco_FormClosed);
            this.Load += new System.EventHandler(this.F_CadastroEndereco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_pais;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtb_cep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_rua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_num;
    }
}