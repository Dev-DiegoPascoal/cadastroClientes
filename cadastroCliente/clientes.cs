using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;


namespace cadastroCliente
{

    public partial class clientes : Form
    {
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
            string conexaoString = "server=localhost;database=cadastroclientes;uid=root;pwd=;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string query = "INSERT INTO clientes (dataCadastro, nome, tipoContato, telefone, cep, longradouro, complemento, bairro, cidade,estado) " +
                        "VALUES (@dataCadastro, @nome, @tipoContato, @telefone, @cep, @longradouro, @complemento, @bairro, @cidade, @estado)";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@dataCadastro", dataCadastro.Text);
                        comando.Parameters.AddWithValue("@nome", txtNome.Text);
                        comando.Parameters.AddWithValue("@tipoContato", cmbTipoContato.Text);
                        comando.Parameters.AddWithValue("@telefone", mskTelefone.Text);
                        comando.Parameters.AddWithValue("@cep", txtCep.Text);
                        comando.Parameters.AddWithValue("@longradouro", txtLongradouro.Text);
                        comando.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                        comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        comando.Parameters.AddWithValue("@estado", txtEstado.Text);

                        DateTime dataCadastroConvertida;
                        if (DateTime.TryParse(dataCadastro.Text, out dataCadastroConvertida))
                        {
                            comando.Parameters.AddWithValue("@data_cadastro", dataCadastroConvertida);
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@data_cadastro", DBNull.Value);
                        }

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cliente cadastrado com sucesso!");

                        txtNome.Clear();
                        cmbTipoContato.Text = "";
                        mskTelefone.Clear();
                        txtCep.Clear();
                        txtLongradouro.Clear();
                        txtComplemento.Clear();
                        txtBairro.Clear();
                        txtCidade.Clear();
                        txtEstado.Clear();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Inconsistência ao gravar os dados: " + ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


