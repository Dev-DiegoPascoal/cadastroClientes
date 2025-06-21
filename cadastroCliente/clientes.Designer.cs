namespace cadastroCliente
{
    partial class clientes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoContato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLongradouro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buscarCep = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(852, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Cadastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Contato";
            // 
            // cmbTipoContato
            // 
            this.cmbTipoContato.FormattingEnabled = true;
            this.cmbTipoContato.Items.AddRange(new object[] {
            "Telefone Residencial",
            "Telefone Comercial",
            "Celular",
            "Outros"});
            this.cmbTipoContato.Location = new System.Drawing.Point(133, 310);
            this.cmbTipoContato.Name = "cmbTipoContato";
            this.cmbTipoContato.Size = new System.Drawing.Size(600, 33);
            this.cmbTipoContato.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(133, 200);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(966, 33);
            this.txtNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número de Telefone";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTelefone.Location = new System.Drawing.Point(772, 304);
            this.mskTelefone.Mask = "(99)00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(327, 39);
            this.mskTelefone.TabIndex = 9;
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(0, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1234, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Endereço";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCep.Location = new System.Drawing.Point(133, 477);
            this.txtCep.Mask = "00.000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(170, 39);
            this.txtCep.TabIndex = 11;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 449);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "CEP";
            // 
            // txtLongradouro
            // 
            this.txtLongradouro.Enabled = false;
            this.txtLongradouro.Location = new System.Drawing.Point(459, 484);
            this.txtLongradouro.Name = "txtLongradouro";
            this.txtLongradouro.Size = new System.Drawing.Size(640, 33);
            this.txtLongradouro.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 456);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Longradouro";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(508, 684);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(466, 33);
            this.txtCidade.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 656);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(459, 584);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(640, 33);
            this.txtBairro.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 556);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(132, 684);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(346, 33);
            this.txtComplemento.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 656);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Complemento";
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGravar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGravar.Location = new System.Drawing.Point(706, 761);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(146, 46);
            this.btnGravar.TabIndex = 21;
            this.btnGravar.Text = "G R A V A R";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(466, 761);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 46);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(0, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1234, 33);
            this.label11.TabIndex = 23;
            this.label11.Text = "Dados Pessoais";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buscarCep
            // 
            this.buscarCep.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buscarCep.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buscarCep.Location = new System.Drawing.Point(309, 477);
            this.buscarCep.Name = "buscarCep";
            this.buscarCep.Size = new System.Drawing.Size(118, 39);
            this.buscarCep.TabIndex = 24;
            this.buscarCep.Text = "Buscar CEP";
            this.buscarCep.UseVisualStyleBackColor = false;
            this.buscarCep.Click += new System.EventHandler(this.buscarCep_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(1005, 684);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(94, 33);
            this.txtEstado.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1005, 656);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Estado";
            // 
            // dataCadastro
            // 
            this.dataCadastro.Enabled = false;
            this.dataCadastro.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataCadastro.Location = new System.Drawing.Point(858, 119);
            this.dataCadastro.Mask = "00/00/0000";
            this.dataCadastro.Name = "dataCadastro";
            this.dataCadastro.Size = new System.Drawing.Size(146, 39);
            this.dataCadastro.TabIndex = 27;
            this.dataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataCadastro.ValidatingType = typeof(System.DateTime);
            this.dataCadastro.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dataCadastro_MaskInputRejected_2);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(132, 584);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(295, 33);
            this.txtNumero.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(133, 556);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "Número";
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataCadastro);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buscarCep);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLongradouro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipoContato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public override bool Equals(object obj)
        {
            return obj is clientes clientes &&
                   EqualityComparer<EventHandler>.Default.Equals(buscarCep_Click_1, clientes.buscarCep_Click_1);
        }

        #endregion
        private Label label2;
        private Label label3;
        private ComboBox cmbTipoContato;
        private Label label1;
        private TextBox txtNome;
        private Label label4;
        private MaskedTextBox mskTelefone;
        private Label label5;
        private MaskedTextBox txtCep;
        private Label label6;
        private TextBox txtLongradouro;
        private Label label7;
        private TextBox txtCidade;
        private Label label8;
        private TextBox txtBairro;
        private Label label9;
        private TextBox txtComplemento;
        private Label label10;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label11;
        private Button buscarCep;
        private EventHandler buscarCep_Click_1;
        private TextBox txtEstado;
        private Label label12;
        private MaskedTextBox dataCadastro;
        private MaskInputRejectedEventHandler dataCadastro_MaskInputRejected;
        private MaskInputRejectedEventHandler dataCadastro_MaskInputRejected_1;
        private TextBox txtNumero;
        private Label label13;
    }
}