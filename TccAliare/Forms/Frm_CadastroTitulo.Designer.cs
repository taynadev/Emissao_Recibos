namespace TccAliare.Forms
{
    partial class Frm_CadastroTitulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroTitulo));
            this.rbReceber = new System.Windows.Forms.RadioButton();
            this.rbPagar = new System.Windows.Forms.RadioButton();
            this.lblBusca = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lvlNumDoc = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.mskValorDoc = new System.Windows.Forms.MaskedTextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.mskCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNomeRazao = new System.Windows.Forms.TextBox();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // rbReceber
            // 
            this.rbReceber.AutoSize = true;
            this.rbReceber.Enabled = false;
            this.rbReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReceber.Location = new System.Drawing.Point(369, 74);
            this.rbReceber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbReceber.Name = "rbReceber";
            this.rbReceber.Size = new System.Drawing.Size(175, 24);
            this.rbReceber.TabIndex = 175;
            this.rbReceber.TabStop = true;
            this.rbReceber.Text = "Conta a Receber";
            this.rbReceber.UseVisualStyleBackColor = true;
            this.rbReceber.CheckedChanged += new System.EventHandler(this.rbReceber_CheckedChanged);
            // 
            // rbPagar
            // 
            this.rbPagar.AutoSize = true;
            this.rbPagar.Enabled = false;
            this.rbPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPagar.Location = new System.Drawing.Point(369, 23);
            this.rbPagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPagar.Name = "rbPagar";
            this.rbPagar.Size = new System.Drawing.Size(154, 24);
            this.rbPagar.TabIndex = 174;
            this.rbPagar.TabStop = true;
            this.rbPagar.Text = "Conta a Pagar";
            this.rbPagar.UseVisualStyleBackColor = true;
            this.rbPagar.CheckedChanged += new System.EventHandler(this.rbPagar_CheckedChanged);
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Enabled = false;
            this.lblBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(662, 26);
            this.lblBusca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(233, 25);
            this.lblBusca.TabIndex = 173;
            this.lblBusca.Text = "Pesquisar CPF / CNPJ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(960, 52);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 38);
            this.btnBuscar.TabIndex = 172;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Enabled = false;
            this.txtPesquisa.Location = new System.Drawing.Point(662, 57);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(290, 26);
            this.txtPesquisa.TabIndex = 171;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Enabled = false;
            this.lblCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCnpj.Location = new System.Drawing.Point(932, 132);
            this.lblCpfCnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(118, 22);
            this.lblCpfCnpj.TabIndex = 170;
            this.lblCpfCnpj.Text = "CPF / CNPJ";
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Enabled = false;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(609, 391);
            this.lblPergunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(0, 29);
            this.lblPergunta.TabIndex = 169;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Enabled = false;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(494, 438);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(129, 25);
            this.lblObs.TabIndex = 168;
            this.lblObs.Text = "Observação";
            // 
            // lvlNumDoc
            // 
            this.lvlNumDoc.AutoSize = true;
            this.lvlNumDoc.Enabled = false;
            this.lvlNumDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNumDoc.Location = new System.Drawing.Point(238, 540);
            this.lvlNumDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlNumDoc.Name = "lvlNumDoc";
            this.lvlNumDoc.Size = new System.Drawing.Size(86, 25);
            this.lvlNumDoc.TabIndex = 167;
            this.lvlNumDoc.Text = "N° Doc.";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Enabled = false;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(238, 455);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(63, 25);
            this.lblValor.TabIndex = 166;
            this.lblValor.Text = "Valor";
            this.lblValor.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Enabled = false;
            this.txtNumDoc.Location = new System.Drawing.Point(238, 571);
            this.txtNumDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(178, 26);
            this.txtNumDoc.TabIndex = 165;
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(498, 469);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(698, 186);
            this.txtObs.TabIndex = 164;
            // 
            // mskValorDoc
            // 
            this.mskValorDoc.Enabled = false;
            this.mskValorDoc.Location = new System.Drawing.Point(238, 486);
            this.mskValorDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskValorDoc.Name = "mskValorDoc";
            this.mskValorDoc.Size = new System.Drawing.Size(178, 26);
            this.mskValorDoc.TabIndex = 163;
            this.mskValorDoc.Enter += new System.EventHandler(this.mskValorDoc_Enter);
            this.mskValorDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskValorDoc_KeyDown);
            this.mskValorDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskValorDoc_KeyPress);
            this.mskValorDoc.Leave += new System.EventHandler(this.mskValorDoc_Leave);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Enabled = false;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(1052, 197);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(0, 22);
            this.lblConsulta.TabIndex = 162;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrar.Location = new System.Drawing.Point(1005, 682);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(174, 51);
            this.btnCadastrar.TabIndex = 160;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnLimpar.Enabled = false;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLimpar.Location = new System.Drawing.Point(1204, 682);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(174, 51);
            this.btnLimpar.TabIndex = 159;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Enabled = false;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(238, 303);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(145, 25);
            this.lblComplemento.TabIndex = 158;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Enabled = false;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(1084, 303);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(79, 25);
            this.lblEstado.TabIndex = 157;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Enabled = false;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(922, 303);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(81, 25);
            this.lblCidade.TabIndex = 156;
            this.lblCidade.Text = "Cidade";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Enabled = false;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(741, 303);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(36, 25);
            this.lblNumero.TabIndex = 155;
            this.lblNumero.Text = "N°";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Enabled = false;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(922, 214);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(56, 25);
            this.lblCep.TabIndex = 154;
            this.lblCep.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Enabled = false;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(676, 214);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(69, 25);
            this.lblBairro.TabIndex = 153;
            this.lblBairro.Text = "Bairro";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Enabled = false;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(238, 214);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(122, 25);
            this.lblLogradouro.TabIndex = 152;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Enabled = false;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(238, 132);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(214, 25);
            this.lblNome.TabIndex = 151;
            this.lblNome.Text = "Nome / Razão Social";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(1089, 334);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(108, 26);
            this.txtEstado.TabIndex = 150;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(927, 334);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(151, 26);
            this.txtCidade.TabIndex = 149;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(746, 334);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(108, 26);
            this.txtNumero.TabIndex = 148;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(238, 334);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(496, 26);
            this.txtComplemento.TabIndex = 147;
            // 
            // mskCep
            // 
            this.mskCep.Enabled = false;
            this.mskCep.Location = new System.Drawing.Point(927, 245);
            this.mskCep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(270, 26);
            this.mskCep.TabIndex = 146;
            // 
            // mskCpfCnpj
            // 
            this.mskCpfCnpj.Enabled = false;
            this.mskCpfCnpj.Location = new System.Drawing.Point(927, 162);
            this.mskCpfCnpj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskCpfCnpj.Name = "mskCpfCnpj";
            this.mskCpfCnpj.Size = new System.Drawing.Size(270, 26);
            this.mskCpfCnpj.TabIndex = 145;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(681, 245);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(172, 26);
            this.txtBairro.TabIndex = 144;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(238, 245);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(408, 26);
            this.txtLogradouro.TabIndex = 143;
            // 
            // txtNomeRazao
            // 
            this.txtNomeRazao.Enabled = false;
            this.txtNomeRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRazao.Location = new System.Drawing.Point(238, 162);
            this.txtNomeRazao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeRazao.Name = "txtNomeRazao";
            this.txtNomeRazao.Size = new System.Drawing.Size(614, 27);
            this.txtNomeRazao.TabIndex = 142;
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnNovoCadastro.FlatAppearance.BorderSize = 0;
            this.btnNovoCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnNovoCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.btnNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNovoCadastro.Location = new System.Drawing.Point(800, 682);
            this.btnNovoCadastro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(174, 51);
            this.btnNovoCadastro.TabIndex = 176;
            this.btnNovoCadastro.Text = "Novo Cadastro";
            this.btnNovoCadastro.UseVisualStyleBackColor = false;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Frm_CadastroTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1490, 757);
            this.Controls.Add(this.btnNovoCadastro);
            this.Controls.Add(this.rbReceber);
            this.Controls.Add(this.rbPagar);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblCpfCnpj);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lvlNumDoc);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.mskValorDoc);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.mskCpfCnpj);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtNomeRazao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CadastroTitulo";
            this.Text = "Frm_CadastroTitulo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbReceber;
        private System.Windows.Forms.RadioButton rbPagar;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lvlNumDoc;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.MaskedTextBox mskValorDoc;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.MaskedTextBox mskCpfCnpj;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtNomeRazao;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}