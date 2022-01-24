using Aliare.DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TccAliare.Impressao;

namespace TccAliare.Forms
{
    public partial class Frm_ListarTitulos : Form
    {
        public Frm_ListarTitulos ()
        {
            InitializeComponent();
        }

        private void btnEditar_Click (object sender, EventArgs e)
        {
            //Abre a tela de editar com todos os dados da linha selecionada
            Frm_EditarTitulo editarTitulo = new Frm_EditarTitulo ();
            if (dgvTitulos.SelectedRows.Count > 0)
            {
                editarTitulo.txtID.Text = dgvTitulos.CurrentRow.Cells["Id"].Value.ToString();
                editarTitulo.txtNome.Text = dgvTitulos.CurrentRow.Cells["Nome"].Value.ToString();
                editarTitulo.mskValor.Text = dgvTitulos.CurrentRow.Cells["Valor"].Value.ToString();
                editarTitulo.txtNumDoc.Text = dgvTitulos.CurrentRow.Cells["Numero"].Value.ToString();
                editarTitulo.txtStatus.Text = dgvTitulos.CurrentRow.Cells["Status"].Value.ToString();
                editarTitulo.txtObs.Text = dgvTitulos.CurrentRow.Cells["Observação"].Value.ToString();
                editarTitulo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma linha!");
            }
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {           
            var id = dgvTitulos.Rows[dgvTitulos.CurrentCell.RowIndex].Cells["ID"].Value;
            //Imprimir recibo = new Imprimir();
            FastReport_Imprime recibo = new FastReport_Imprime();
            if (rbRecebedor.Checked)
            {
                recibo.DadosRecibo(((int)id));
            }
            else if (rbPagador.Checked)
            {
                recibo.DadosRecibo(((int)id));
            }
            else
            {
                MessageBox.Show("Selecione o tipo de titulo que deseja buscar (Pagamento ou Recebimento)",
                                "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (rbRecebedor.Checked)
            {
                RecebedorRepository recebedorRepository = new RecebedorRepository();
                var recebimentos = recebedorRepository
                .GetByNome(txtConsultaTitulo.Text);

                dgvTitulos.DataSource = recebimentos;
                dgvTitulos.Columns[0].Visible = false;
            }
            else if (rbPagador.Checked)
            {
                PagarRepository pagarRepository = new PagarRepository();
                var pagamentos = pagarRepository
                .GetByNome(txtConsultaTitulo.Text);               

                dgvTitulos.DataSource = pagamentos;
                dgvTitulos.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("Selecione o tipo de titulo que deseja buscar (Pagamento ou Recebimento)",
                "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dgvTitulos.AutoResizeColumns(
            DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void txtConsultaTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
