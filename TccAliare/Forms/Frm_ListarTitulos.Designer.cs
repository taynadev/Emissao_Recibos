namespace TccAliare.Forms
{
    partial class Frm_ListarTitulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListarTitulos));
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvTitulos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtConsultaTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRecibo = new System.Windows.Forms.Button();
            this.rbPagador = new System.Windows.Forms.RadioButton();
            this.rbRecebedor = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.Location = new System.Drawing.Point(1272, 686);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(153, 52);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvTitulos
            // 
            this.dgvTitulos.AllowUserToAddRows = false;
            this.dgvTitulos.AllowUserToDeleteRows = false;
            this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulos.Location = new System.Drawing.Point(57, 192);
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.ReadOnly = true;
            this.dgvTitulos.RowHeadersWidth = 51;
            this.dgvTitulos.RowTemplate.Height = 24;
            this.dgvTitulos.Size = new System.Drawing.Size(1368, 471);
            this.dgvTitulos.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(423, 138);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 37);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtConsultaTitulo
            // 
            this.txtConsultaTitulo.Location = new System.Drawing.Point(57, 143);
            this.txtConsultaTitulo.Name = "txtConsultaTitulo";
            this.txtConsultaTitulo.Size = new System.Drawing.Size(356, 26);
            this.txtConsultaTitulo.TabIndex = 15;
            this.txtConsultaTitulo.TextChanged += new System.EventHandler(this.txtConsultaTitulo_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(58, 115);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 22);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Nome / Razão Social";
            // 
            // btnRecibo
            // 
            this.btnRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnRecibo.FlatAppearance.BorderSize = 0;
            this.btnRecibo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnRecibo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.btnRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRecibo.Location = new System.Drawing.Point(1052, 686);
            this.btnRecibo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(190, 52);
            this.btnRecibo.TabIndex = 17;
            this.btnRecibo.Text = "Gerar Recibo";
            this.btnRecibo.UseVisualStyleBackColor = false;
            this.btnRecibo.Click += new System.EventHandler(this.btnRecibo_Click);
            // 
            // rbPagador
            // 
            this.rbPagador.AutoSize = true;
            this.rbPagador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPagador.Location = new System.Drawing.Point(57, 60);
            this.rbPagador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPagador.Name = "rbPagador";
            this.rbPagador.Size = new System.Drawing.Size(107, 26);
            this.rbPagador.TabIndex = 18;
            this.rbPagador.TabStop = true;
            this.rbPagador.Text = "A Pagar";
            this.rbPagador.UseVisualStyleBackColor = true;
            // 
            // rbRecebedor
            // 
            this.rbRecebedor.AutoSize = true;
            this.rbRecebedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecebedor.Location = new System.Drawing.Point(192, 60);
            this.rbRecebedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRecebedor.Name = "rbRecebedor";
            this.rbRecebedor.Size = new System.Drawing.Size(129, 26);
            this.rbRecebedor.TabIndex = 19;
            this.rbRecebedor.TabStop = true;
            this.rbRecebedor.Text = "A Receber";
            this.rbRecebedor.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Frm_ListarTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1490, 757);
            this.Controls.Add(this.rbRecebedor);
            this.Controls.Add(this.rbPagador);
            this.Controls.Add(this.btnRecibo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtConsultaTitulo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvTitulos);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListarTitulos";
            this.Text = "Frm_ListarTitulos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvTitulos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtConsultaTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.RadioButton rbPagador;
        private System.Windows.Forms.RadioButton rbRecebedor;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}