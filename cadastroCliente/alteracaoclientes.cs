using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Newtonsoft.Json;


namespace cadastroCliente
{
    public partial class alteracaoclientes : Form
    {
        private int codigoCliente;
        private MySqlTransaction? transacao;

        public alteracaoclientes(MySqlTransaction? transacao)
        {
            this.transacao = transacao;
        }

        public alteracaoclientes(int codigo)
        {
            InitializeComponent();
            codigoCliente = codigo;
            CarregarDadosCliente();
        }


        private void CarregarDadosCliente()
        {
            string conexaoString = "server=localhost;database=cadastroclientes;uid=root;pwd=;";
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();
                    string query = @"
                        SELECT 
                            c.dataCadastro,
                            c.nome, 
                            ct.tipo AS tipoContato, 
                            ct.descricao AS telefone,
                            e.cep, 
                            e.longradouro, 
                            e.numero, 
                            e.complemento, 
                            e.bairro, 
                            e.cidade, 
                            e.estado
                        FROM clientes c
                        LEFT JOIN contato ct ON c.codigo = ct.codigo_cliente
                        LEFT JOIN endereco e ON c.codigo = e.codigo_cliente
                        WHERE c.codigo = @codigo";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@codigo", codigoCliente);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dataCadastro.Text = reader["dataCadastro"].ToString();
                                txtNome.Text = reader["nome"].ToString();
                                cmbTipoContato.Text = reader["tipoContato"].ToString();
                                mskTelefone.Text = reader["telefone"].ToString();
                                txtCep.Text = reader["cep"].ToString();
                                txtLongradouro.Text = reader["longradouro"].ToString();
                                txtNumero.Text = reader["numero"].ToString();
                                txtComplemento.Text = reader["complemento"].ToString();
                                txtBairro.Text = reader["bairro"].ToString();
                                txtCidade.Text = reader["cidade"].ToString();
                                txtEstado.Text = reader["estado"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados do cliente: " + ex.Message);
                }
            }
        }

        private MySqlTransaction? Transacao => transacao;

        public class ViaCepResponse
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public bool erro { get; set; }
        }

        private async void buscarCep_Click(object sender, EventArgs e)
        {
            string cep = new string(txtCep.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(cep) || cep.Length != 8)
            {
                MessageBox.Show("Por favor, informe um CEP válido com 8 números.");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";

                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string jsonResult = await response.Content.ReadAsStringAsync();

                    var endereco = JsonConvert.DeserializeObject<ViaCepResponse>(jsonResult);

                    if (endereco != null && endereco.erro != true)
                    {
                        txtLongradouro.Text = endereco.logradouro;
                        txtBairro.Text = endereco.bairro;
                        txtCidade.Text = endereco.localidade;
                        txtEstado.Text = endereco.uf;
                    }
                    else
                    {
                        MessageBox.Show("CEP não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o CEP: {ex.Message}");
            }
        }

        private MySqlTransaction? Transacao1 => transacao;

        private MySqlTransaction? GetTransacao()
        {
            return transacao;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string conexaoString = "server=localhost;database=cadastroclientes;uid=root;pwd=;";
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();

                using (MySqlTransaction transacaoLocal = conexao.BeginTransaction())
                {
                    try
                    {
                        // Atualizar CLIENTES
                        string queryClientes = "UPDATE clientes SET nome = @nome WHERE codigo = @codigo";
                        using (MySqlCommand cmdClientes = new MySqlCommand(queryClientes, conexao, transacaoLocal))
                        {
                            cmdClientes.Parameters.AddWithValue("@nome", txtNome.Text);
                            cmdClientes.Parameters.AddWithValue("@codigo", codigoCliente);
                            cmdClientes.ExecuteNonQuery();
                        }

                        // Atualizar CONTATO
                        string queryContato = "UPDATE contato SET tipo = @tipo, descricao = @descricao WHERE codigo_cliente = @codigo";
                        using (MySqlCommand cmdContato = new MySqlCommand(queryContato, conexao, transacaoLocal))
                        {
                            cmdContato.Parameters.AddWithValue("@tipo", cmbTipoContato.Text);
                            cmdContato.Parameters.AddWithValue("@descricao", mskTelefone.Text);
                            cmdContato.Parameters.AddWithValue("@codigo", codigoCliente);
                            cmdContato.ExecuteNonQuery();
                        }

                        // Atualizar ENDEREÇO
                        string queryEndereco = @"
                    UPDATE endereco 
                    SET cep = @cep, longradouro = @longradouro, numero = @numero, 
                        complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado
                    WHERE codigo_cliente = @codigo";
                        using (MySqlCommand cmdEndereco = new MySqlCommand(queryEndereco, conexao, transacaoLocal))
                        {
                            cmdEndereco.Parameters.AddWithValue("@cep", txtCep.Text);
                            cmdEndereco.Parameters.AddWithValue("@longradouro", txtLongradouro.Text);
                            cmdEndereco.Parameters.AddWithValue("@numero", txtNumero.Text);
                            cmdEndereco.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                            cmdEndereco.Parameters.AddWithValue("@bairro", txtBairro.Text);
                            cmdEndereco.Parameters.AddWithValue("@cidade", txtCidade.Text);
                            cmdEndereco.Parameters.AddWithValue("@estado", txtEstado.Text);
                            cmdEndereco.Parameters.AddWithValue("@codigo", codigoCliente);
                            cmdEndereco.ExecuteNonQuery();
                        }

                        transacaoLocal.Commit();
                        MessageBox.Show("Dados atualizados com sucesso!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transacaoLocal.Rollback();
                        MessageBox.Show("Erro ao atualizar os dados: " + ex.Message);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
