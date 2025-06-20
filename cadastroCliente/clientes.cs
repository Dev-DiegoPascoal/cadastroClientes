using Newtonsoft.Json;
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
                        txtBairro.Text = endereco.bairro;        // Aqui parece que o nome do campo não condiz com o conteúdo
                        txtCidade.Text = endereco.localidade;
                        txtEstado.Text = endereco.uf;       // Talvez renomear para txtEstado
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
    }
}

