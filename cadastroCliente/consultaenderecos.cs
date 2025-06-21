using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroCliente
{
    public partial class consultaenderecos : Form
    {
        public consultaenderecos()
        {
            InitializeComponent();
            CarregarEnderecos();
        }

        private void dgvConsultaEnderecos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarEnderecos();
        }
        private void CarregarEnderecos()
        {
            string conexaoString = "server=localhost;database=cadastroclientes;uid=root;pwd=;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT cep, longradouro," +
                        "bairro, cidade, estado FROM endereco";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexao))
                    {
                        DataTable tabelaClientes = new DataTable();
                        adaptador.Fill(tabelaClientes);

                        dgvConsultaEnderecos.DataSource = tabelaClientes;

                        dgvConsultaEnderecos.Columns["cep"].HeaderText = "CEP";
                        dgvConsultaEnderecos.Columns["longradouro"].HeaderText = "Longradouro";
                        dgvConsultaEnderecos.Columns["bairro"].HeaderText = "Bairro";
                        dgvConsultaEnderecos.Columns["cidade"].HeaderText = "Cidade";
                     
                        dgvConsultaEnderecos.Columns["cep"].Width = 123;
                        dgvConsultaEnderecos.Columns["longradouro"].Width = 350;
                        dgvConsultaEnderecos.Columns["bairro"].Width = 320;
                        dgvConsultaEnderecos.Columns["cidade"].Width = 250;
                     
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
                }

                dgvConsultaEnderecos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvConsultaEnderecos.MultiSelect = false;
                dgvConsultaEnderecos.ReadOnly = true;
                dgvConsultaEnderecos.AllowUserToAddRows = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
