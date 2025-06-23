namespace cadastroCliente
{
    partial class consultaenderecos
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
            this.label11 = new System.Windows.Forms.Label();
            this.dgvConsultaEnderecos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimparConsulta = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(0, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1234, 48);
            this.label11.TabIndex = 27;
            this.label11.Text = "Consulta de Endereços";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvConsultaEnderecos
            // 
            this.dgvConsultaEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaEnderecos.Location = new System.Drawing.Point(25, 188);
            this.dgvConsultaEnderecos.Name = "dgvConsultaEnderecos";
            this.dgvConsultaEnderecos.RowTemplate.Height = 25;
            this.dgvConsultaEnderecos.Size = new System.Drawing.Size(1186, 523);
            this.dgvConsultaEnderecos.TabIndex = 26;
            this.dgvConsultaEnderecos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaEnderecos_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(556, 759);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 46);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "VOLTAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimparConsulta
            // 
            this.btnLimparConsulta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimparConsulta.Location = new System.Drawing.Point(886, 121);
            this.btnLimparConsulta.Name = "btnLimparConsulta";
            this.btnLimparConsulta.Size = new System.Drawing.Size(127, 39);
            this.btnLimparConsulta.TabIndex = 32;
            this.btnLimparConsulta.Text = "Limpar";
            this.btnLimparConsulta.UseVisualStyleBackColor = true;
            this.btnLimparConsulta.Click += new System.EventHandler(this.btnLimparConsulta_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(736, 121);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(127, 39);
            this.btnConsultar.TabIndex = 31;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConsulta.Location = new System.Drawing.Point(214, 121);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(499, 39);
            this.txtConsulta.TabIndex = 30;
            // 
            // consultaenderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.btnLimparConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvConsultaEnderecos);
            this.MaximizeBox = false;
            this.Name = "consultaenderecos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Endereços";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEnderecos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label11;
        private DataGridView dgvConsultaEnderecos;
        private Button btnCancelar;
        private Button btnLimparConsulta;
        private Button btnConsultar;
        private TextBox txtConsulta;
    }
}