using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace cadastroCliente
{

    public partial class clientes : Form
    {
        private object comando;
        private object cmdContato;

        public EventHandler Clientes_Load { get; }

        public clientes()
        {
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            dataCadastro.Mask = "00/00/0000";
            dataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

        private void PreencherDataCadastro()
        {
            dataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void dataCadastro_MaskInputRejected_2(object sender, MaskInputRejectedEventArgs e)
        {
            dataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnGravar_Click(object sender, EventArgs e)

        {

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                 string.IsNullOrWhiteSpace(cmbTipoContato.Text) ||
                 string.IsNullOrWhiteSpace(mskTelefone.Text) ||
                 string.IsNullOrWhiteSpace(txtCep.Text) ||
                 string.IsNullOrWhiteSpace(txtLongradouro.Text) ||
                 string.IsNullOrWhiteSpace(txtComplemento.Text) ||
                 string.IsNullOrWhiteSpace(txtNumero.Text) ||
                 string.IsNullOrWhiteSpace(txtBairro.Text) ||
                 string.IsNullOrWhiteSpace(txtCidade.Text) ||
                 string.IsNullOrWhiteSpace(txtEstado.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
                string conexaoString = "server=localhost;database=cadastroclientes;uid=root;pwd=;";

                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();

                    using (MySqlTransaction transacao = conexao.BeginTransaction())
                    {
                        try
                        {
                            // 1) Inserir cliente
                            string queryCliente = "INSERT INTO clientes (dataCadastro, nome) VALUES (@dataCadastro, @nome)";
                            long clienteId;

                            using (MySqlCommand cmdCliente = new MySqlCommand(queryCliente, conexao, transacao))
                            {
                                cmdCliente.Parameters.AddWithValue("@dataCadastro", DateTime.Now);
                                cmdCliente.Parameters.AddWithValue("@nome", txtNome.Text);
                                cmdCliente.ExecuteNonQuery();

                                clienteId = cmdCliente.LastInsertedId; // pega o ID gerado
                            }

                        string queryContato = "INSERT INTO contato (codigo_cliente, tipo, descricao) VALUES (@codigo_cliente, @tipo, @descricao)";
                        using (MySqlCommand cmdContato = new MySqlCommand(queryContato, conexao, transacao))
                        {
                            cmdContato.Parameters.AddWithValue("@codigo_cliente", clienteId);
                            cmdContato.Parameters.AddWithValue("@tipo", cmbTipoContato.Text);
                            cmdContato.Parameters.AddWithValue("@descricao", mskTelefone.Text);
                            cmdContato.ExecuteNonQuery();
                        }


                        string queryEndereco = "INSERT INTO endereco (codigo_cliente, cep, longradouro, numero, complemento, bairro, cidade, estado) " +
                       "VALUES (@codigo_cliente, @cep, @longradouro, @numero, @complemento, @bairro, @cidade, @estado)";
                        using (MySqlCommand cmdEndereco = new MySqlCommand(queryEndereco, conexao, transacao))
                        {
                            cmdEndereco.Parameters.AddWithValue("@codigo_cliente", clienteId);
                            cmdEndereco.Parameters.AddWithValue("@cep", txtCep.Text);
                            cmdEndereco.Parameters.AddWithValue("@longradouro", txtLongradouro.Text);
                            cmdEndereco.Parameters.AddWithValue("@numero", txtNumero.Text);
                            cmdEndereco.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                            cmdEndereco.Parameters.AddWithValue("@bairro", txtBairro.Text);
                            cmdEndereco.Parameters.AddWithValue("@cidade", txtCidade.Text);
                            cmdEndereco.Parameters.AddWithValue("@estado", txtEstado.Text);
                            cmdEndereco.ExecuteNonQuery();
                        }

                        // Commit na transação: confirma tudo
                        transacao.Commit();

                            MessageBox.Show("Cliente cadastrado com sucesso!");


                        this.Close();

                        consultaclientes telaCliente = new consultaclientes();
                        telaCliente.Show();
                    }
                        catch (Exception ex)
                        {
                            transacao.Rollback(); // desfaz tudo se der erro
                            MessageBox.Show("Erro ao gravar os dados: " + ex.Message);
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


