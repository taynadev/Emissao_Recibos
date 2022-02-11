using Aliare.DataBase.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TccAliare.Forms
{


    public partial class Frm_EditarTitulo : Form
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

        public Frm_EditarTitulo ()
        {
            InitializeComponent();
        }

        private void Frm_EditarTitulo_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click (object sender, EventArgs e)
        {
            Close();
        }

        #region Altera Mascara valor do documento
        private void mskValorDoc_Leave (object sender, EventArgs e)
        {
            if (mskValorDoc.Text.Replace("R$", "").Replace(",", "") != "")
            {
                mskValorDoc.Text = Convert.ToDouble(mskValorDoc.Text).ToString("C");
            }
            else
            {
                MessageBox.Show("Há campos obrigatorios a serem preenchidos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(mskValorDoc, "Preencha o campo");
            }
        }

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

        private void btnCancelar_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (mskValorDoc.Text.Replace("R$", "").Replace(",", "") != "")
            {
                PagarRepository pagamento = new PagarRepository();
                var p = pagamento.GetById(int.Parse(txtID.Text));
                p.Valor = Decimal.Parse(mskValorDoc.Text.Replace("R$", ""));
                p.Numero = txtNumDoc.Text;
                p.Status = txtStatus.Text;
                p.Observacao = txtObs.Text;

                pagamento.Update(p);
                pagamento.Save();

                MessageBox.Show("Atualizado com sucesso!", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Há campos obrigatorios a serem preenchidos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(mskValorDoc, "Preencha o campo");
            }

          
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            RecebedorRepository receber = new RecebedorRepository();
            var r = receber.GetById(int.Parse(txtID.Text));

            receber.Remove(r);
            receber.Save();

            MessageBox.Show("Excluído com sucesso!", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.None);

            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtNumDoc.Enabled = false;
            txtObs.Enabled = false;
            txtStatus.Enabled = false;
            mskCpfCnpj.Enabled = false;
            mskValorDoc.Enabled = false;

            btnAtualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
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

        private void mskValorDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }
    }
}
