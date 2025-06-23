namespace cadastroCliente;
using MySql.Data.MySqlClient;


    partial class consultaclientes
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
            this.dgvConsultaClientes = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnIncluirCliente = new System.Windows.Forms.PictureBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimparConsulta = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIncluirCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaClientes
            // 
            this.dgvConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaClientes.Location = new System.Drawing.Point(24, 191);
            this.dgvConsultaClientes.Name = "dgvConsultaClientes";
            this.dgvConsultaClientes.RowTemplate.Height = 25;
            this.dgvConsultaClientes.Size = new System.Drawing.Size(1186, 434);
            this.dgvConsultaClientes.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(238, 752);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 46);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "VOLTAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(852, 752);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(146, 46);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "E X C L U I R";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(0, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1234, 48);
            this.label11.TabIndex = 25;
            this.label11.Text = "Consulta de Clientes";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIncluirCliente
            // 
            this.btnIncluirCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnIncluirCliente.Image = global::cadastroCliente.Properties.Resources._436361_vector_adicionar_icone_gratis_vetor;
            this.btnIncluirCliente.Location = new System.Drawing.Point(1103, 647);
            this.btnIncluirCliente.Name = "btnIncluirCliente";
            this.btnIncluirCliente.Size = new System.Drawing.Size(71, 61);
            this.btnIncluirCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnIncluirCliente.TabIndex = 26;
            this.btnIncluirCliente.TabStop = false;
            this.btnIncluirCliente.Click += new System.EventHandler(this.btnIncluirCliente_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConsulta.Location = new System.Drawing.Point(159, 121);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(499, 39);
            this.txtConsulta.TabIndex = 27;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(681, 121);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(127, 39);
            this.btnConsultar.TabIndex = 28;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimparConsulta
            // 
            this.btnLimparConsulta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimparConsulta.Location = new System.Drawing.Point(831, 121);
            this.btnLimparConsulta.Name = "btnLimparConsulta";
            this.btnLimparConsulta.Size = new System.Drawing.Size(127, 39);
            this.btnLimparConsulta.TabIndex = 29;
            this.btnLimparConsulta.Text = "Limpar";
            this.btnLimparConsulta.UseVisualStyleBackColor = true;
            this.btnLimparConsulta.Click += new System.EventHandler(this.btnLimparConsulta_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.Location = new System.Drawing.Point(545, 752);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(146, 46);
            this.btnAlterar.TabIndex = 30;
            this.btnAlterar.Text = "EDITAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // consultaclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnLimparConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnIncluirCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvConsultaClientes);
            this.MaximizeBox = false;
            this.Name = "consultaclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIncluirCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvConsultaClientes;
    private Button btnCancelar;
    private Button btnExcluir;
    private Label label11;
    private PictureBox btnIncluirCliente;
    private TextBox txtConsulta;
    private Button btnConsultar;
    private Button btnLimparConsulta;
    private Button btnAlterar;
}
