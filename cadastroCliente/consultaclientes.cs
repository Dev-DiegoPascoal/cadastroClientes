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
            dgvConsultaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaClientes.MultiSelect = false;
            dgvConsultaClientes.ReadOnly = true;
            dgvConsultaClientes.AllowUserToAddRows = false;

            string conexaoString = "server=localhost;database=cadastroclientes;uid=root;pwd=;";
            DataTable tabelaClientes = new DataTable();

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string query = @"
                        SELECT 
                            c.codigo,
                            c.dataCadastro,
                            c.nome,
                            ct.tipo AS tipoContato,
                            ct.descricao,
                            e.cep,
                            e.longradouro,
                            e.numero,
                            e.complemento,
                            e.bairro,
                            e.cidade
                        FROM clientes c
                        LEFT JOIN contato ct ON c.codigo = ct.codigo_cliente
                        LEFT JOIN endereco e ON c.codigo = e.codigo_cliente;
                    ";


                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexao))
                    {
                        adaptador.Fill(tabelaClientes);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
                    return;
                }
            }

            dgvConsultaClientes.DataSource = tabelaClientes;

            if (dgvConsultaClientes.Columns.Contains("codigo"))
                dgvConsultaClientes.Columns["codigo"].Visible = false;

            dgvConsultaClientes.Columns["dataCadastro"].HeaderText = "Data do Cadastro";
            dgvConsultaClientes.Columns["nome"].HeaderText = "Nome do Cliente";
            dgvConsultaClientes.Columns["tipoContato"].HeaderText = "Tipo de Contato";
            dgvConsultaClientes.Columns["descricao"].HeaderText = "Telefone";
            dgvConsultaClientes.Columns["cep"].HeaderText = "CEP";
            dgvConsultaClientes.Columns["longradouro"].HeaderText = "Longradouro";
            dgvConsultaClientes.Columns["numero"].HeaderText = "Número";
            dgvConsultaClientes.Columns["complemento"].HeaderText = "Complemento";
            dgvConsultaClientes.Columns["bairro"].HeaderText = "Bairro";
            dgvConsultaClientes.Columns["cidade"].HeaderText = "Cidade";
         

            dgvConsultaClientes.Columns["dataCadastro"].Width = 75;
            dgvConsultaClientes.Columns["nome"].Width = 205;
            dgvConsultaClientes.Columns["tipoContato"].Width = 80;
            dgvConsultaClientes.Columns["descricao"].Width = 90;
            dgvConsultaClientes.Columns["cep"].Width = 75;
            dgvConsultaClientes.Columns["longradouro"].Width = 225;
            dgvConsultaClientes.Columns["numero"].Width = 77;
            dgvConsultaClientes.Columns["complemento"].Width = 115;
            dgvConsultaClientes.Columns["bairro"].Width = 102;
            dgvConsultaClientes.Columns["cidade"].Width = 100;
          

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
                    "Tem certeza que deseja excluir este cliente? Fazendo isso o endereço atribuído a ele " +
                    "também será excluído!",
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string filtro = txtConsulta.Text.Trim();

            if (!string.IsNullOrEmpty(filtro))
            {
                // Cast para o DataTable atual da Grid
                DataTable? tabela = dgvConsultaClientes.DataSource as DataTable;

                if (tabela != null)
                {
                    // Cria um filtro do tipo LIKE (Exemplo: filtro por Nome)
                    string filtroExpressao = $"nome LIKE '%{filtro}%'";

                    DataView dv = new DataView(tabela);
                    dv.RowFilter = filtroExpressao;

                    dgvConsultaClientes.DataSource = dv;
                }
            }
            else
            {
                // Se o campo estiver vazio, recarrega a lista completa
                CarregarClientes();
            }
        }

        private void btnLimparConsulta_Click(object sender, EventArgs e)
        {
            txtConsulta.Clear();  
            CarregarClientes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvConsultaClientes.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgvConsultaClientes.SelectedRows[0].Cells["codigo"].Value);

                alteracaoclientes telaAlteracao = new alteracaoclientes(codigo);
                telaAlteracao.ShowDialog();

                // Recarregar após a alteração
                CarregarClientes();
            }
            else
            {
                MessageBox.Show("Selecione um cliente para alterar.");
            }
        }
    }
}

