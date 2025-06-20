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
    public partial class consultaclientes : Form
    {
        public consultaclientes()
        {
            InitializeComponent();
            CarregarClientes();
        }

        private void dgvConsultaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarClientes();
        }
        private void CarregarClientes()
        {
            string conexaoString = "server=localhost;database=cadastroclientes;uid=root;pwd=;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT codigo, dataCadastro, nome, tipoContato, telefone, cep, longradouro, complemento," +
                        "bairro, cidade, estado FROM clientes";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexao))
                    {
                        DataTable tabelaClientes = new DataTable();
                        adaptador.Fill(tabelaClientes);

                        dgvConsultaClientes.DataSource = tabelaClientes;

                        dgvConsultaClientes.Columns["codigo"].Visible = false;
                        dgvConsultaClientes.Columns["dataCadastro"].HeaderText = "Data do Cadastro";
                        dgvConsultaClientes.Columns["nome"].HeaderText = "Nome do Cliente";
                        dgvConsultaClientes.Columns["tipoContato"].HeaderText = "Tipo de Contato";
                        dgvConsultaClientes.Columns["telefone"].HeaderText = "Telefone";
                        dgvConsultaClientes.Columns["cep"].HeaderText = "CEP";
                        dgvConsultaClientes.Columns["longradouro"].HeaderText = "Longradouro";
                        dgvConsultaClientes.Columns["complemento"].HeaderText = "Complemento";
                        dgvConsultaClientes.Columns["bairro"].HeaderText = "Bairro";
                        dgvConsultaClientes.Columns["cidade"].HeaderText = "Cidade";
                        dgvConsultaClientes.Columns["estado"].HeaderText = "Estado";

                        dgvConsultaClientes.Columns["dataCadastro"].Width = 70;
                        dgvConsultaClientes.Columns["nome"].Width = 220;
                        dgvConsultaClientes.Columns["tipoContato"].Width = 80;
                        dgvConsultaClientes.Columns["telefone"].Width = 90;
                        dgvConsultaClientes.Columns["cep"].Width = 75;
                        dgvConsultaClientes.Columns["longradouro"].Width = 225;
                        dgvConsultaClientes.Columns["complemento"].Width = 150;
                        dgvConsultaClientes.Columns["bairro"].Width = 90;
                        dgvConsultaClientes.Columns["cidade"].Width = 100;
                        dgvConsultaClientes.Columns["estado"].Width = 43;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
                }

                dgvConsultaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvConsultaClientes.MultiSelect = false;
                dgvConsultaClientes.ReadOnly = true;
                dgvConsultaClientes.AllowUserToAddRows = false;
            }
        }



       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvConsultaClientes.SelectedRows.Count > 0)
            {

                int codigo = Convert.ToInt32(dgvConsultaClientes.SelectedRows[0].Cells["codigo"].Value);

                DialogResult resultado = MessageBox.Show(
                    "Tem certeza que deseja excluir este cliente?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    string conexaoString = "server=localhost;database=cadastroclientes;uid=root;pwd=;";

                    using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                    {
                        try
                        {
                            conexao.Open();

                            string query = "DELETE FROM clientes WHERE codigo = @codigo";
                            using (MySqlCommand comando = new MySqlCommand(query, conexao))
                            {
                                comando.Parameters.AddWithValue("@codigo", codigo);
                                comando.ExecuteNonQuery();
                            }

                            MessageBox.Show("Cliente excluído com sucesso!");

                            CarregarClientes();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente na tabela antes de excluir.");
            }
        }

        private void btnIncluirCliente_Click(object sender, EventArgs e)
        {
            clientes telaCliente = new clientes();
            telaCliente.Show();
            CarregarClientes();
        }
    }
}
