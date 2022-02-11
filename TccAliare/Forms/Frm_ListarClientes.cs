using Aliare.DataBase.Repositories;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace TccAliare.Forms
{
    public partial class Frm_ListarClientes : Form
    {



        public Frm_ListarClientes ()
        {
            InitializeComponent();
        }


        private void Frm_ListarClientes_Load (object sender, EventArgs e)
        {

        }

        private void btnEditar_Click (object sender, EventArgs e)
        {

            Frm_EditarCliente editarCliente = new Frm_EditarCliente();
            if (dgvClientes.SelectedRows.Count > 0)
            {
                editarCliente.txtID.Text = dgvClientes.CurrentRow.Cells["Id"].Value.ToString();
                editarCliente.mskCpfCnpj.Text = dgvClientes.CurrentRow.Cells["CpfCnpj"].Value.ToString();
                editarCliente.txtCep.Text = dgvClientes.CurrentRow.Cells["Cep"].Value.ToString();
                editarCliente.txtNome.Text = dgvClientes.CurrentRow.Cells["Nome"].Value.ToString();
                editarCliente.txtLogradouro.Text = dgvClientes.CurrentRow.Cells["Logradouro"].Value.ToString();
                editarCliente.txtBairro.Text = dgvClientes.CurrentRow.Cells["Bairro"].Value.ToString();
                editarCliente.txtComplemento.Text = dgvClientes.CurrentRow.Cells["Complemento"].Value.ToString();
                editarCliente.txtNum.Text = dgvClientes.CurrentRow.Cells["Numero"].Value.ToString();
                editarCliente.txtCidade.Text = dgvClientes.CurrentRow.Cells["NomeCidade"].Value.ToString();
                editarCliente.txtUf.Text = dgvClientes.CurrentRow.Cells["Uf"].Value.ToString();
                editarCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma linha!");
            }
        }

        private void btnBuscar_Click (object sender, EventArgs e)
        {
            DataTable table = new DataTable { Locale = CultureInfo.InvariantCulture };


            ClienteRepository clirep = new ClienteRepository();
            var cliente = clirep.GetByNome(txtNome.Text);
            dgvClientes.DataSource = cliente;
            
            dgvClientes.Columns["CpfCnpj"].HeaderText = "CPF/CNPJ";
            dgvClientes.Columns["Nome"].HeaderText = "Nome / Razão Social";
            dgvClientes.Columns["NomeCidade"].HeaderText = "Cidade";

            if(dgvClientes.Rows.Count > 0)
            {
                dgvClientes.Columns[0].Visible = false;
                dgvClientes.Columns[8].Visible = false;

                dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
