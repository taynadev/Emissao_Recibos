using Aliare.DataBase.Repositories;
using System;
using System.Windows.Forms;

namespace TccAliare.Forms
{
    public partial class Frm_EditarCliente : Form
    {
        #region funcoes para habilitar o arraste da janela
        //Codigo para habilitar o arraste da janela
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage (IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture ();
        #endregion



       
        public Frm_EditarCliente ()
        {
            InitializeComponent();
          
        }

        private void btnClose_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_EditarCliente_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCancelar_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ClienteRepository cliente = new ClienteRepository();
            var cli = cliente.GetById(int.Parse(txtID.Text));
            cli.CpfCnpj = mskCpfCnpj.Text;
            cli.Nome = txtNome.Text;

            EnderecoRepository endereco = new EnderecoRepository();
            var end = endereco.GetById(cli.EnderecoId);
            end.Logradouro = txtLogradouro.Text;
            end.Bairro = txtBairro.Text;
            end.Complemento = txtComplemento.Text;
            end.Numero = txtNum.Text;

            CidadeRepository cidade = new CidadeRepository();
            var cid = cidade.GetById(end.CidadeId);
            cid.Nome = txtCidade.Text;
            cid.Uf = txtUf.Text;

            cliente.Update(cli);
            endereco.Update(end);
            cidade.Update(cid);
            cliente.Save();
            endereco.Save();
            cidade.Save();

            MessageBox.Show("Atualizado com sucesso!", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.None);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteRepository cliente = new ClienteRepository();
                var cli = cliente.GetById(int.Parse(txtID.Text));

                EnderecoRepository endereco = new EnderecoRepository();
                var end = endereco.GetById(cli.EnderecoId);

                CidadeRepository cidade = new CidadeRepository();
                var cid = cidade.GetById(end.CidadeId);

                cliente.Remove(cli);
                cliente.Save();
                endereco.Remove(end);
                endereco.Save();
                cidade.Remove(cid);
                cidade.Save();

                MessageBox.Show("Excluído com sucesso!", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.None);

                txtID.Enabled = false;
                txtBairro.Enabled = false;
                txtCep.Enabled = false;
                txtCidade.Enabled = false;
                txtComplemento.Enabled = false;
                txtLogradouro.Enabled = false;
                txtNome.Enabled = false;
                txtNum.Enabled = false;
                txtUf.Enabled = false;
                mskCpfCnpj.Enabled = false;

                btnExcluir.Enabled = false;
                btnAtualizar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            catch (Exception en)
            {
                MessageBox.Show("Este cliente possui titulos cadastrados pendentes, por isso não e possivel apagar o cadastro",
                "Falha ao Tentar Excluir!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void mskCpfCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void Frm_EditarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
