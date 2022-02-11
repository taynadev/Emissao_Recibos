using Aliare.DataBase.Repositories;
using SistemaFinanceiro.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TccAliare.Forms
{
    public partial class Frm_CadastroTitulo : Form
    {
        private int id = 0;
        public Frm_CadastroTitulo ()
        {
            InitializeComponent();
        }

        #region Ações dos botoões
        private void btnNovoCadastro_Click_1 (object sender, EventArgs e)
        {
            rbPagar.Enabled = true;
            rbReceber.Enabled = true;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;
        }

        private void btnBuscar_Click (object sender, EventArgs e)
        {
            mskValorDoc.Enabled = true;
            txtNumDoc.Enabled = true;
            txtObs.Enabled = true;

            if (rbReceber.Checked)
            {
                ClienteRepository clienteRepository = new ClienteRepository();
                var cliente = clienteRepository.GetByCpfCnpj(txtPesquisa.Text);

                if (cliente == null)
                {
                    MessageBox.Show("Dados não encontrados, verifique se digitou corretamente", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    id = cliente.Id;

                    txtNomeRazao.Text = cliente.Nome;
                    mskCpfCnpj.Text = cliente.CpfCnpj;
                    txtLogradouro.Text = cliente.Endereco.Logradouro;
                    txtBairro.Text = cliente.Endereco.Bairro;
                    mskCep.Text = cliente.Endereco.Cep;
                    txtComplemento.Text = cliente.Endereco.Complemento;
                    txtNumero.Text = cliente.Endereco.Numero.ToString();
                    txtCidade.Text = cliente.Endereco.Cidade.Nome;
                    txtEstado.Text = cliente.Endereco.Cidade.Uf;
                }
                
            }

            if (rbPagar.Checked)
            {
                FornecedorRepository fornecedorRepository = new FornecedorRepository();
                var fornecedor = fornecedorRepository.GetByCnpjCpf(txtPesquisa.Text);

                if (fornecedor == null)
                {
                    MessageBox.Show("Dados não encontrados, verifique se digitou corretamente", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    id = fornecedor.Id;

                    txtNomeRazao.Text = fornecedor.Nome;
                    txtLogradouro.Text = fornecedor.Endereco.Logradouro;
                    txtBairro.Text = fornecedor.Endereco.Bairro;
                    mskCpfCnpj.Text = fornecedor.CnpjCpf;
                    mskCep.Text = fornecedor.Endereco.Cep;
                    txtComplemento.Text = fornecedor.Endereco.Complemento;
                    txtNumero.Text = fornecedor.Endereco.Numero.ToString();
                    txtCidade.Text = fornecedor.Endereco.Cidade.Nome;
                    txtEstado.Text = fornecedor.Endereco.Cidade.Uf;
                }
                
            }
        }

        private void btnLimpar_Click (object sender, EventArgs e)
        {
            rbPagar.Checked = false;
            rbReceber.Checked = false;
            lblPergunta.Text = "";
            txtPesquisa.Text = "";
            txtNomeRazao.Text = "";
            mskCpfCnpj.Text = "";
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            mskCep.Text = "";
            txtComplemento.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";

            txtPesquisa.Enabled = false;
            btnBuscar.Enabled = false;
            mskValorDoc.Enabled=false;
            txtNumDoc.Enabled=false;
            txtObs.Enabled=false;

        }

        #endregion



        #region Açoes do RadioButton

        private void rbPagar_CheckedChanged (object sender, EventArgs e)
        {
            lblPergunta.Text = "Cadastrar conta a pagar:";
            txtPesquisa.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void rbReceber_CheckedChanged (object sender, EventArgs e)
        {
            lblPergunta.Text = "Cadastrar conta a receber:";
            txtPesquisa.Enabled = true;
            btnBuscar.Enabled = true;
        }




        #endregion

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
           
        }

        #region Botão cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string conteudoValorDoc = mskValorDoc.Text;
            conteudoValorDoc = conteudoValorDoc.Replace("-", "").Replace("_", "").Replace("R$", "").Replace(".", "");
            conteudoValorDoc = conteudoValorDoc.Trim();

            if (rbReceber.Checked)
            {
                if (txtNomeRazao.Text == "" || conteudoValorDoc == "")
                {
                    errorProvider.SetError(txtPesquisa, "Preencha o campo");
                    errorProvider.SetError(mskValorDoc, "Preencha o campo");
                    MessageBox.Show("Há campos necessários para serem preenchidos", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    ReceberModel receber = new ReceberModel();
                    RecebedorRepository con = new RecebedorRepository();
                    receber.EmpresaId = 1;
                    receber.ClienteId = id;
                    receber.Numero = txtNumDoc.Text;
                    receber.Valor = Decimal.Parse(mskValorDoc.Text.Replace("R$", "").Replace(".", "").Replace(".", ""));
                    receber.Observacao = txtObs.Text;
                    receber.Data = DateTime.Now;
                    receber.Status = "A";

                    con.Add(receber);
                    con.Save();

                    MessageBox.Show("Salvo com sucesso", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.None);


                    txtNomeRazao.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    txtComplemento.Text = "";
                    txtEstado.Text = "";
                    txtLogradouro.Text = "";
                    txtNumDoc.Text = "";
                    txtNumero.Text = "";
                    txtObs.Text = "";
                    txtPesquisa.Text = "";
                    mskCep.Text = "";
                    mskCpfCnpj.Text = "";
                    mskValorDoc.Text = "";
                    rbPagar.Checked = false;
                    rbReceber.Checked = false;
                    
                }

                mskValorDoc.Text = "";
                txtNumDoc.Text = "";
                txtObs.Text = "";
                mskValorDoc.Enabled = false;
                txtNumDoc.Enabled = false;
                txtObs.Enabled = false;
                rbPagar.Checked = false;
                rbPagar.Enabled = false;
                rbReceber.Checked = false;
                rbReceber.Enabled = false;
                txtPesquisa.Text = "";
                txtPesquisa.Enabled = false;

                
            }

            if (rbPagar.Checked)
            {
                if (txtNomeRazao.Text == "" || conteudoValorDoc == "")
                {
                    errorProvider.SetError(txtPesquisa, "Preencha o campo");
                    errorProvider.SetError(mskValorDoc, "Preencha o campo");
                    MessageBox.Show("Há campos necessários para serem preenchidos", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    PagarModel pagar = new PagarModel();
                    PagarRepository con = new PagarRepository();
                    pagar.EmpresaId = 1;
                    pagar.FornecedorId = id;
                    pagar.Numero = txtNumDoc.Text;
                    pagar.Valor = Decimal.Parse(mskValorDoc.Text.Replace("R$", "").Replace(".", "").Replace(".", ""));
                    pagar.Observacao = txtObs.Text;
                    pagar.Data = DateTime.Now;
                    pagar.Status = "A";

                    con.Add(pagar);
                    con.Save();

                    MessageBox.Show("Salvo com sucesso", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.None);

                    txtNomeRazao.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";
                    txtComplemento.Text = "";
                    txtEstado.Text = "";
                    txtLogradouro.Text = "";
                    txtNumDoc.Text = "";
                    txtNumero.Text = "";
                    txtObs.Text = "";
                    txtPesquisa.Text = "";
                    mskCep.Text = "";
                    mskCpfCnpj.Text = "";
                    mskValorDoc.Text = "";
                    rbPagar.Checked = false;
                    rbReceber.Checked = false;
                }

                
            }
        }
        #endregion

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        #region Tratamento de Mascara Valor do Titulo
        //converte para o formato monerário com o R$
        private void mskValorDoc_Leave (object sender, EventArgs e)
        {
            if(mskValorDoc.Text.Replace("R$", "").Replace(",", "") != "")
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

        private void mskValorDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void Frm_CadastroTitulo_Load(object sender, EventArgs e)
        {

        }
    }
}
