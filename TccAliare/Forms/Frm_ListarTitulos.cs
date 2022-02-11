﻿using Aliare.DataBase.Repositories;
using System;
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
            if (rbPagador.Checked)
            {
                Frm_EditarTituloPagar editarTituloPagar = new Frm_EditarTituloPagar();
                if (dgvTitulos.SelectedRows.Count > 0)
                {
                    editarTituloPagar.txtID.Text = dgvTitulos.CurrentRow.Cells["Id"].Value.ToString();
                    editarTituloPagar.mskCpfCnpj.Text = dgvTitulos.CurrentRow.Cells["CPF"].Value.ToString();
                    editarTituloPagar.txtNome.Text = dgvTitulos.CurrentRow.Cells["Fornecedor"].Value.ToString();
                    editarTituloPagar.mskValorDoc.Text = dgvTitulos.CurrentRow.Cells["Valor"].Value.ToString();
                    editarTituloPagar.txtNumDoc.Text = dgvTitulos.CurrentRow.Cells["Numero"].Value.ToString();
                    editarTituloPagar.txtStatus.Text = dgvTitulos.CurrentRow.Cells["Status"].Value.ToString();
                    editarTituloPagar.txtObs.Text = dgvTitulos.CurrentRow.Cells["Observacao"].Value.ToString();
                    editarTituloPagar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecione uma linha!");
                }
            }
            else if (rbRecebedor.Checked)
            {
                Frm_EditarTitulo editarTitulo = new Frm_EditarTitulo();
                if (dgvTitulos.SelectedRows.Count > 0)
                {
                    editarTitulo.txtID.Text = dgvTitulos.CurrentRow.Cells["Id"].Value.ToString();
                    editarTitulo.mskCpfCnpj.Text = dgvTitulos.CurrentRow.Cells["CPF"].Value.ToString();
                    editarTitulo.txtNome.Text = dgvTitulos.CurrentRow.Cells["Cliente"].Value.ToString();
                    editarTitulo.mskValorDoc.Text = dgvTitulos.CurrentRow.Cells["Valor"].Value.ToString();
                    editarTitulo.txtNumDoc.Text = dgvTitulos.CurrentRow.Cells["Numero"].Value.ToString();
                    editarTitulo.txtStatus.Text = dgvTitulos.CurrentRow.Cells["Status"].Value.ToString();
                    editarTitulo.txtObs.Text = dgvTitulos.CurrentRow.Cells["Observacao"].Value.ToString();
                    editarTitulo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecione uma linha!");
                }
            }

        }

        private void btnRecibo_Click (object sender, EventArgs e)
        {

            if (rbRecebedor.Checked)
            {
                if(dgvTitulos.SelectedRows.Count > 0)
                {
                    var id = dgvTitulos.Rows[dgvTitulos.CurrentCell.RowIndex].Cells["ID"].Value;
                    //Imprimir recibo = new Imprimir();
                    FastReport_Imprime recibo = new FastReport_Imprime();
                    recibo.DadosRecibo(((int)id));
                }
                else
                {
                    MessageBox.Show("Selecione uma linha!");
                }
                
            }
            else if (rbPagador.Checked)
            {
                if(dgvTitulos.SelectedRows.Count >0)
                {
                    var id = dgvTitulos.Rows[dgvTitulos.CurrentCell.RowIndex].Cells["ID"].Value;
                    //Imprimir recibo = new Imprimir();
                    FastReport_Imprime recibo = new FastReport_Imprime();
                    recibo.DadosPagamento(((int)id));
                }
                else
                {
                    MessageBox.Show("Selecione uma linha!");
                }
                
            }
            else
            {
                MessageBox.Show("Selecione o tipo de titulo que deseja buscar (Pagamento ou Recebimento)",
                                "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider.SetError(rbPagador, "Escolha o campo");
                errorProvider.SetError(rbRecebedor, "Escolha o campo");
            }
        }

        private void btnBuscar_Click (object sender, EventArgs e)
        {

            if (rbRecebedor.Checked)
            {
                RecebedorRepository recebedorRepository = new RecebedorRepository();
                var recebimentos = recebedorRepository
                .GetByNome(txtConsultaTitulo.Text);

                dgvTitulos.DataSource = recebimentos;
                if (dgvTitulos.Rows.Count > 0)
                {
                    dgvTitulos.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("Dados não encontrados, insira novamente os dados", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rbPagador.Checked)
            {
                PagarRepository pagarRepository = new PagarRepository();
                var pagamentos = pagarRepository
                .GetByNome(txtConsultaTitulo.Text);

                dgvTitulos.DataSource = pagamentos;
                if (dgvTitulos.Rows.Count > 0)
                {
                    dgvTitulos.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("Dados não encontrados, insira novamente os dados", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione o tipo de titulo que deseja buscar (Pagamento ou Recebimento)",
                "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dgvTitulos.AutoResizeColumns(
            DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void txtConsultaTitulo_TextChanged (object sender, EventArgs e)
        {

        }
    }
}
