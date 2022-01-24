using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TccAliare.Forms;

namespace TccAliare
{
    public partial class Frm_Principal : Form
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


        //variavel para form no pane central
        private Form frmAtivo;


        public Frm_Principal ()
        {
            InitializeComponent();
            customizarDesing();
        }

        #region Codigo para habilitar o arraste da janela com click
        //habilita o painel superior para arrastar com o click do mouse
        private void paneTitulo_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion


        #region Codigo para abrir e fechar o menu
        private void customizarDesing ()
        {
            paneCadastro.Visible = false;
            paneConsultar.Visible = false;
        }

        private void esconderSubMenu ()
        {
            if (paneCadastro.Visible == true)
            {
                paneCadastro.Visible = false;
            }
            if (paneConsultar.Visible == true)
            {
                paneConsultar.Visible = false;
            }
        }

        private void mostrarSubMenu (Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnCadastro_Click (object sender, EventArgs e)
        {
            mostrarSubMenu(paneCadastro);
        }

        private void btnConsultar_Click (object sender, EventArgs e)
        {
            mostrarSubMenu(paneConsultar);
        }
        #endregion


        #region Codigo para ativar os botoes de minimizar e fechar
        private void btnClose_Click (object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        #region Codigo para abrir as janelas no painel central
        //Metodo para mostrar o formulario no painel central
        private void FormShow (Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            paneCentral.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

        }

        private void ActiveFormClose ()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();


            }
        }

        private void ActiveButton (Button frmAtivo)
        {
            foreach (Control ctrl in paneMenuGeral.Controls) //executa conjunto de comandos
                ctrl.ForeColor = Color.White; //altera a cor da letra do button nao ativo
            frmAtivo.ForeColor = Color.Red; // altera a cor da letra do button ativo
        }
        #endregion


        #region Eventos de click nos botões de Cadastro
        private void btnMenu_Click (object sender, EventArgs e)
        {

            ActiveFormClose();
            lblTitulo.Text = "Menu Principal";
            paneTitulo.BackColor = Color.Black;
            lblTitulo.ForeColor = Color.Gainsboro;
            esconderSubMenu();
        }

        private void btnCliente_Click (object sender, EventArgs e)
        {

            FormShow(new Frm_CadastroCliente());
            lblTitulo.Text = "Cadastro de Clientes";
            paneTitulo.BackColor = Color.FromArgb(((int) (((byte) (1)))), ((int) (((byte) (195)))), ((int) (((byte) (220)))));
            lblTitulo.ForeColor = Color.Black;

        }

        private void btnFornecedor_Click (object sender, EventArgs e)
        {
            FormShow(new Frm_CadastroFornecedor());
            lblTitulo.Text = "Cadastro de Fornecedores";
            paneTitulo.BackColor = Color.White;
            lblTitulo.ForeColor = Color.Black;

        }

       

        private void btnTitulos_Click (object sender, EventArgs e)
        {
            FormShow(new Frm_CadastroTitulo());
            lblTitulo.Text = "Cadastro de Titulos";
            paneTitulo.BackColor = Color.FromArgb(((int) (((byte) (89)))), ((int) (((byte) (214)))), ((int) (((byte) (76)))));
            lblTitulo.ForeColor = Color.Black;
        }

        // Ativa a cor dos Botões ao passar o mouse
        private void btnFornecedor_MouseHover (object sender, EventArgs e)
        {
            btnFornecedor.ForeColor = Color.Black;
        }

        private void btnFornecedor_MouseLeave (object sender, EventArgs e)
        {

            btnFornecedor.ForeColor = Color.White;
        }

        private void btnTitulos_MouseHover (object sender, EventArgs e)
        {
            btnTitulos.ForeColor = Color.Black;
        }

        private void btnTitulos_MouseLeave (object sender, EventArgs e)
        {
            btnTitulos.ForeColor = Color.White;
        }
        #endregion


        #region Codigo para ativar atalhos de teclado
        private void Frm_Principal_KeyDown (object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                ActiveFormClose();
                lblTitulo.Text = "Menu Principal";
                paneTitulo.BackColor = Color.Black;
                lblTitulo.ForeColor = Color.Gainsboro;
                esconderSubMenu();

                break;

                case Keys.F1:
                mostrarSubMenu(paneCadastro);
                FormShow(new Frm_CadastroCliente());
                lblTitulo.Text = "Cadastro de Clientes";
                paneTitulo.BackColor = Color.FromArgb(((int) (((byte) (1)))), ((int) (((byte) (195)))), ((int) (((byte) (220)))));
                lblTitulo.ForeColor = Color.Black;
                break;

                case Keys.F2:
                mostrarSubMenu(paneConsultar);
                FormShow(new Frm_ListarClientes());
                lblTitulo.Text = "Consultar Clientes";
                break;
            }
        }






        #endregion


        #region Eventos de click dos botões Consultar
        private void btnListCliente_Click (object sender, EventArgs e)
        {

            FormShow(new Frm_ListarClientes());
            lblTitulo.Text = "Consulta de Clientes";
        }
        private void btnListFornece_Click (object sender, EventArgs e)
        {
            FormShow(new Frm_ListarFornecedores());
            lblTitulo.Text = "Consulta de Fornecedores";
        }

        private void btnListTitulo_Click (object sender, EventArgs e)
        {
            FormShow(new Frm_ListarTitulos());
            lblTitulo.Text = "Consulta de Titulos";
        }

        #endregion


    }
}