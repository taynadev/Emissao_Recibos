using Aliare.DataBase.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccAliare.Forms
{
    public partial class Frm_ListarFornecedores : Form
    {

        public Frm_ListarFornecedores ()
        {
            InitializeComponent();
        }

        private void btnEditar_Click (object sender, EventArgs e)
        {
            Frm_EditarFornecedor editarFornecedor = new Frm_EditarFornecedor();

            if (dgvFornecedores.SelectedRows.Count > 0)
            {
                
                editarFornecedor.txtID.Text = dgvFornecedores.CurrentRow.Cells["Id"].Value.ToString();
                editarFornecedor.txtCnpjCpf.Text = dgvFornecedores.CurrentRow.Cells["CnpjCpf"].Value.ToString();
                editarFornecedor.txtCep.Text = dgvFornecedores.CurrentRow.Cells["Cep"].Value.ToString();
                editarFornecedor.txtNome.Text = dgvFornecedores.CurrentRow.Cells["Nome"].Value.ToString();
                editarFornecedor.txtLogradouro.Text = dgvFornecedores.CurrentRow.Cells["Logradouro"].Value.ToString();
                editarFornecedor.txtBairro.Text = dgvFornecedores.CurrentRow.Cells["Bairro"].Value.ToString();
                editarFornecedor.txtComplemento.Text = dgvFornecedores.CurrentRow.Cells["Complemento"].Value.ToString();
                editarFornecedor.txtNumero.Text = dgvFornecedores.CurrentRow.Cells["Numero"].Value.ToString();
                editarFornecedor.txtCidade.Text = dgvFornecedores.CurrentRow.Cells["NomeCidade"].Value.ToString();
                editarFornecedor.txtUF.Text = dgvFornecedores.CurrentRow.Cells["Uf"].Value.ToString();
                editarFornecedor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma linha!");
            }
            
        }

        private void btnBuscar_Click (object sender, EventArgs e)
        {
            DataTable table = new DataTable { Locale = CultureInfo.InvariantCulture };

            FornecedorRepository forn = new FornecedorRepository();
            var fornecedor = forn.GetByNome(txtNome.Text);
            dgvFornecedores.DataSource = fornecedor;
            dgvFornecedores.Columns["CnpjCpf"].HeaderText = "CNPJ/CPF";
            dgvFornecedores.Columns["NomeCidade"].HeaderText = "Cidade";

            if (dgvFornecedores.Rows.Count > 0)
            {
                dgvFornecedores.Columns[0].Visible = false;
                dgvFornecedores.Columns[8].Visible = false;

                dgvFornecedores.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                MessageBox.Show("Dados não encontrados, insira novamente os dados", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNome_TextChanged (object sender, EventArgs e)
        {

        }
    }
}
