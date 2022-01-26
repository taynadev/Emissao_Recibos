using Aliare.DataBase.Repositories;
using Newtonsoft.Json;
using SistemaFinanceiro.Context;
using SistemaFinanceiro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TccAliare.ClassesSuporte;


namespace TccAliare.Forms
{
    public partial class Frm_CadastroCliente : Form
    {
        public Frm_CadastroCliente ()
        {
            InitializeComponent();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        #region Codigo para converter mascara de CPF e CNPJ
        //Converte mascara para CPF
        private void rbCPF_CheckedChanged (object sender, EventArgs e)
        {
            mskCpfCnpj.Text = "";
            if (rbCPF.Checked && mskCpfCnpj.Enabled == false)
            {
                mskCpfCnpj.Mask = "000,000,000-00";
                mskCpfCnpj.Enabled = true;
            }
            else
            {
                mskCpfCnpj.Enabled = false;
            }
        }

        //Converte mascara para CNPJ
        private void rbCNPJ_CheckedChanged (object sender, EventArgs e)
        {
            mskCpfCnpj.Text = "";

            if (rbCNPJ.Checked && mskCpfCnpj.Enabled == false)
            {
                mskCpfCnpj.Mask = "00,000,000/0000-00";
                mskCpfCnpj.Enabled = true;
            }
            else
            {
                mskCpfCnpj.Enabled = false;
            }
        }

        #endregion


        #region Codigo para validar CPF ou CNPJ apos usuario clicar em outro campo
        private void mskCpfCnpj_Leave (object sender, EventArgs e)
        {
            string conteudoCPF;
            conteudoCPF = mskCpfCnpj.Text;
            conteudoCPF = conteudoCPF.Replace(".", "").Replace("-", "");
            conteudoCPF = conteudoCPF.Trim();

            string conteudoCNPJ = mskCpfCnpj.Text;
            conteudoCNPJ = conteudoCNPJ.Replace(".", "");
            conteudoCNPJ = conteudoCNPJ.Replace("/", "");
            conteudoCNPJ = conteudoCNPJ.Replace("-", "");
            conteudoCNPJ = conteudoCNPJ.Trim();

            if (rbCPF.Checked)
            {

                if (conteudoCPF.Length != 11)
                {
                    MessageBox.Show("CPF deve conter 11 digitos!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool validaCPF = false;
                    validaCPF = ValidaPfPj.ValidaCPF(mskCpfCnpj.Text);
                    if (validaCPF == true)
                    {
                        lblConsulta.Text = "CPF Válido!";
                        lblConsulta.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblConsulta.Text = "CPF Inválido!";
                        lblConsulta.ForeColor = Color.Red;
                    }
                }

            }
            if (rbCNPJ.Checked)
            {


                if (conteudoCNPJ.Length != 14)
                {
                    MessageBox.Show("CNPJ deve conter 14 digitos!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                bool validaCNPJ = false;

                validaCNPJ = ValidaPfPj.ValidaCNPJ(mskCpfCnpj.Text);
                if (validaCNPJ == true)
                {
                    lblConsulta.Text = "CNPJ Válido!";
                    lblConsulta.ForeColor = Color.Green;
                }
                else
                {
                    lblConsulta.Text = "CNPJ Inválido!";
                    lblConsulta.ForeColor = Color.Red;
                }
            }
        }

        #endregion


        #region Codigo para preencher os campos de endereço apos o usuario informar o CEP e clicar em outro campo 
        private void mskCep_Leave (object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mskCep.Text))
            {
                MessageBox.Show("Informe um CEP valido!", this.Text, MessageBoxButtons.OK);
            }
            else
            {
                string strURL = string.Format("https://viacep.com.br/ws/{0}/json/", mskCep.Text.Trim());

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = client.GetAsync(strURL).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            var result = response.Content.ReadAsStringAsync().Result;
                            ConsultaCep res = JsonConvert.DeserializeObject<ConsultaCep>(result);

                            txtLogradouro.Text = res.Logradouro;
                            txtComplemento.Text = res.Complemento;
                            txtCidade.Text = res.Localidade;
                            txtEstado.Text = res.Estado;
                            txtBairro.Text = res.Bairro;

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        #endregion


        #region Codigos de evento click dos botões

        private void btnLimpar_Click (object sender, EventArgs e)
        {
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtNomeRazao.Text = "";
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
            txtEstado.Text = "";
            mskCep.Text = "";
            mskCpfCnpj.Text = "";
            mskCpfCnpj.Mask = "";
            mskCpfCnpj.Enabled = false;
            rbCPF.Checked = false;
            rbCNPJ.Checked = false;
            lblConsulta.Text = "";
            ckbSim.Checked = false;
            mskValorDoc.Enabled = false;
            txtNumDoc.Enabled = false;
            txtObs.Enabled = false;
            txtObs.Text = "";
            txtNumDoc.Text = "";
            mskValorDoc.Text = "";
        }

        private void btnNovoCadastro_Click (object sender, EventArgs e)
        {
            txtNomeRazao.Enabled = true;
            rbCPF.Enabled = true;
            rbCNPJ.Enabled = true;
            txtLogradouro.Enabled = true;
            txtBairro.Enabled = true;
            mskCep.Enabled = true;
            txtComplemento.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            ckbSim.Enabled = true;
            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;
        }




        #endregion


        #region Codigo para liberar ou bloquear campos de cadastro de titulo
        private void ckbSim_CheckedChanged (object sender, EventArgs e)
        {
            if (ckbSim.Checked)
            {
                mskValorDoc.Enabled = true;
                txtNumDoc.Enabled = true;
                txtObs.Enabled = true;
            }
            else
            {
                mskValorDoc.Enabled = false;
                txtNumDoc.Enabled = false;
                txtObs.Enabled = false;
            }
        }


        #endregion

        private void Frm_CadastroCliente_Load (object sender, EventArgs e)
        {

        }

        #region Botão cadastrar e validações

        private void btnCadastrar_Click (object sender, EventArgs e)
        {
            string conteudoCPF;
            conteudoCPF = mskCpfCnpj.Text;
            conteudoCPF = conteudoCPF.Replace(".", "").Replace("-", "");
            conteudoCPF = conteudoCPF.Trim();

            string conteudoCNPJ = mskCpfCnpj.Text;
            conteudoCNPJ = conteudoCNPJ.Replace(".", "");
            conteudoCNPJ = conteudoCNPJ.Replace("/", "");
            conteudoCNPJ = conteudoCNPJ.Replace("-", "");
            conteudoCNPJ = conteudoCNPJ.Trim();

            string conteudoCEP = mskCep.Text;
            conteudoCEP = conteudoCEP.Replace("-", "").Replace("_", "");
            conteudoCEP = conteudoCEP.Trim();

            string conteudoValorDoc = mskValorDoc.Text;
            conteudoValorDoc = conteudoValorDoc.Replace("-", "").Replace("_", "").Replace("R$", "");
            conteudoValorDoc = conteudoValorDoc.Trim();


            if (txtNomeRazao.Text == "" || conteudoCPF == "" || conteudoCNPJ == "" || conteudoCEP == "")
            {
                errorProvider.SetError(txtNomeRazao, "Preencha o campo");
                errorProvider.SetError(mskCpfCnpj, "Preencha o campo");
                errorProvider.SetError(mskCep, "Preencha o campo");

                MessageBox.Show("Há campos obrigatorios a serem preenchidos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ckbSim.Checked)
            {
                if (conteudoValorDoc == "")
                {
                    errorProvider.SetError(mskValorDoc, "Preencha o campo");

                    MessageBox.Show("Há campos obrigatorios a serem preenchidos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var cliente = new ClienteModel();
                    var endereco = new EnderecoModel();
                    var receber = new ReceberModel();
                    var cidade = new CidadeModel();

                    var rp_cliente = new ClienteRepository();
                    var rp_receber = new RecebedorRepository();

                    cidade.Nome = txtCidade.Text;
                    cidade.Uf = txtEstado.Text;

                    endereco.Bairro = txtBairro.Text;
                    endereco.Complemento = txtComplemento.Text;
                    endereco.Logradouro = txtLogradouro.Text;
                    endereco.Cep = mskCep.Text.Replace("-", "");
                    endereco.Numero = txtNumero.Text;
                    endereco.Cidade = cidade;

                    cliente.Nome = txtNomeRazao.Text;
                    cliente.CpfCnpj = mskCpfCnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "");
                    ;
                    cliente.Endereco = endereco;

                    rp_cliente.Add(cliente);
                    rp_cliente.Save();


                    receber.EmpresaId = 1;
                    receber.ClienteId = cliente.Id;
                    receber.Numero = txtNumDoc.Text;
                    receber.Observacao = txtObs.Text;
                    receber.Data = DateTime.Now;
                    receber.Status = "A";
                    receber.Valor = decimal.Parse(mskValorDoc.Text.Replace("R$", "").Replace(".", "").Replace(".", ""));

                    rp_receber.Add(receber);
                    rp_receber.Save();

                    MessageBox.Show("Dados salvos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.None);

                    btnLimpar_Click(sender, e);
                }
            }
            else
            {
                var cliente = new ClienteModel();
                var endereco = new EnderecoModel();
                var receber = new ReceberModel();
                var cidade = new CidadeModel();

                var rp_cliente = new ClienteRepository();
                var rp_receber = new RecebedorRepository();

                cidade.Nome = txtCidade.Text;
                cidade.Uf = txtEstado.Text;

                endereco.Bairro = txtBairro.Text;
                endereco.Complemento = txtComplemento.Text;
                endereco.Logradouro = txtLogradouro.Text;
                endereco.Cep = mskCep.Text.Replace("-", "");
                endereco.Numero = txtNumero.Text;
                endereco.Cidade = cidade;

                cliente.Nome = txtNomeRazao.Text;
                cliente.CpfCnpj = mskCpfCnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "");
                ;
                cliente.Endereco = endereco;

                rp_cliente.Add(cliente);
                rp_cliente.Save();

                MessageBox.Show("Dados salvos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.None);

                btnLimpar_Click(sender, e);
            }

        }
        #endregion

        #region Impedir o usuário de dar espaço

        private void mskCpfCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void mskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void mskValorDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }
        #endregion

        #region Altera a Mascara do Valor do Documento

        //converte para o formato monerário com o R$
        private void mskValorDoc_Leave (object sender, EventArgs e)
        {
            if (mskValorDoc.Text != "")
            {
                mskValorDoc.Text = Convert.ToDouble(mskValorDoc.Text).ToString("C");
            }
            else
            {
                MessageBox.Show("Há campos obrigatorios a serem preenchidos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //evita que letras sejam digitadas, faz com que o ponto seja substituido por virgula e que exista apenas uma virgula na string
        private void mskValorDoc_KeyPress (object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char) 13 && e.KeyChar != (Char) 8))
            {
                e.KeyChar = (Char) 0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!mskValorDoc.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char) 0;
                    }
                }
            }
        }

        //Retira a formatação quando o campo perde o foco ou recebe um valor
        private void mskValorDoc_Enter (object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= mskValorDoc.Text.Length - 1; i++)
            {
                if ((mskValorDoc.Text[i] >= '0' &&
                    mskValorDoc.Text[i] <= '9') ||
                    mskValorDoc.Text[i] == ',')
                {
                    x += mskValorDoc.Text[i];
                }
            }
            mskValorDoc.Text = x;
            mskValorDoc.SelectAll();
        }

        #endregion

        
    }
}
