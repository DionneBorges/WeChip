
namespace WeChip.Views
{
    partial class FrmOferta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.btnOfertar = new System.Windows.Forms.Button();
            this.lFiltro = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.lSaldo = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.lTelefone = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.lCPF = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lNome = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.gvStatus = new System.Windows.Forms.DataGridView();
            this.gbMercadoria = new System.Windows.Forms.GroupBox();
            this.gvProdutos = new System.Windows.Forms.DataGridView();
            this.ok = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbEntrega = new System.Windows.Forms.GroupBox();
            this.tbUF = new System.Windows.Forms.TextBox();
            this.lUF = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lCidade = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lBairro = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.lComplemento = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lNumero = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.lRua = new System.Windows.Forms.Label();
            this.tbCEP = new System.Windows.Forms.TextBox();
            this.lCEP = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.lTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStatus)).BeginInit();
            this.gbMercadoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).BeginInit();
            this.gbEntrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbBusca);
            this.panel1.Controls.Add(this.btnOfertar);
            this.panel1.Controls.Add(this.lFiltro);
            this.panel1.Controls.Add(this.cbFiltro);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 34);
            this.panel1.TabIndex = 1;
            // 
            // cbBusca
            // 
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Location = new System.Drawing.Point(138, 3);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(280, 23);
            this.cbBusca.TabIndex = 20;
            this.cbBusca.Enter += new System.EventHandler(this.cbBusca_Enter);
            this.cbBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBusca_KeyPress);
            this.cbBusca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbBusca_KeyUp);
            // 
            // btnOfertar
            // 
            this.btnOfertar.Location = new System.Drawing.Point(424, 2);
            this.btnOfertar.Name = "btnOfertar";
            this.btnOfertar.Size = new System.Drawing.Size(75, 23);
            this.btnOfertar.TabIndex = 4;
            this.btnOfertar.Text = "Ofertar";
            this.btnOfertar.UseVisualStyleBackColor = true;
            this.btnOfertar.Click += new System.EventHandler(this.btnOfertar_Click);
            // 
            // lFiltro
            // 
            this.lFiltro.AutoSize = true;
            this.lFiltro.Location = new System.Drawing.Point(9, 6);
            this.lFiltro.Name = "lFiltro";
            this.lFiltro.Size = new System.Drawing.Size(37, 15);
            this.lFiltro.TabIndex = 1;
            this.lFiltro.Text = "Filtro:";
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Nome",
            "CPF"});
            this.cbFiltro.Location = new System.Drawing.Point(52, 3);
            this.cbFiltro.MaxDropDownItems = 2;
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(80, 23);
            this.cbFiltro.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbCliente);
            this.panel2.Controls.Add(this.gbStatus);
            this.panel2.Controls.Add(this.gbMercadoria);
            this.panel2.Controls.Add(this.gbEntrega);
            this.panel2.Controls.Add(this.btnConcluir);
            this.panel2.Controls.Add(this.lTotal);
            this.panel2.Location = new System.Drawing.Point(12, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 459);
            this.panel2.TabIndex = 2;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lStatus);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.tbSaldo);
            this.gbCliente.Controls.Add(this.lSaldo);
            this.gbCliente.Controls.Add(this.tbTelefone);
            this.gbCliente.Controls.Add(this.lTelefone);
            this.gbCliente.Controls.Add(this.tbCPF);
            this.gbCliente.Controls.Add(this.lCPF);
            this.gbCliente.Controls.Add(this.tbNome);
            this.gbCliente.Controls.Add(this.lNome);
            this.gbCliente.Location = new System.Drawing.Point(0, 3);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(530, 91);
            this.gbCliente.TabIndex = 24;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Informações do cliente";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lStatus.ForeColor = System.Drawing.Color.Navy;
            this.lStatus.Location = new System.Drawing.Point(334, 63);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 20);
            this.lStatus.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Status:";
            // 
            // tbSaldo
            // 
            this.tbSaldo.BackColor = System.Drawing.Color.LimeGreen;
            this.tbSaldo.Enabled = false;
            this.tbSaldo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbSaldo.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSaldo.Location = new System.Drawing.Point(213, 60);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(70, 23);
            this.tbSaldo.TabIndex = 27;
            this.tbSaldo.Text = "0,00";
            this.tbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lSaldo
            // 
            this.lSaldo.AutoSize = true;
            this.lSaldo.Location = new System.Drawing.Point(168, 63);
            this.lSaldo.Name = "lSaldo";
            this.lSaldo.Size = new System.Drawing.Size(39, 15);
            this.lSaldo.TabIndex = 26;
            this.lSaldo.Text = "Saldo:";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(420, 22);
            this.tbTelefone.MaxLength = 15;
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.PlaceholderText = "Telefone";
            this.tbTelefone.Size = new System.Drawing.Size(100, 23);
            this.tbTelefone.TabIndex = 25;
            // 
            // lTelefone
            // 
            this.lTelefone.AutoSize = true;
            this.lTelefone.Location = new System.Drawing.Point(360, 25);
            this.lTelefone.Name = "lTelefone";
            this.lTelefone.Size = new System.Drawing.Size(54, 15);
            this.lTelefone.TabIndex = 24;
            this.lTelefone.Text = "Telefone:";
            // 
            // tbCPF
            // 
            this.tbCPF.Enabled = false;
            this.tbCPF.Location = new System.Drawing.Point(55, 60);
            this.tbCPF.MaxLength = 15;
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.PlaceholderText = "CPF";
            this.tbCPF.Size = new System.Drawing.Size(100, 23);
            this.tbCPF.TabIndex = 23;
            // 
            // lCPF
            // 
            this.lCPF.AutoSize = true;
            this.lCPF.Location = new System.Drawing.Point(18, 63);
            this.lCPF.Name = "lCPF";
            this.lCPF.Size = new System.Drawing.Size(31, 15);
            this.lCPF.TabIndex = 22;
            this.lCPF.Text = "CPF:";
            // 
            // tbNome
            // 
            this.tbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNome.Location = new System.Drawing.Point(55, 22);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.PlaceholderText = "Nome do Cliente";
            this.tbNome.Size = new System.Drawing.Size(294, 23);
            this.tbNome.TabIndex = 21;
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Location = new System.Drawing.Point(6, 25);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(43, 15);
            this.lNome.TabIndex = 20;
            this.lNome.Text = "Nome:";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.gvStatus);
            this.gbStatus.Location = new System.Drawing.Point(355, 211);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(175, 202);
            this.gbStatus.TabIndex = 23;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Novo Status";
            // 
            // gvStatus
            // 
            this.gvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStatus.Location = new System.Drawing.Point(6, 22);
            this.gvStatus.MultiSelect = false;
            this.gvStatus.Name = "gvStatus";
            this.gvStatus.ReadOnly = true;
            this.gvStatus.RowHeadersVisible = false;
            this.gvStatus.RowHeadersWidth = 10;
            this.gvStatus.RowTemplate.Height = 25;
            this.gvStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStatus.Size = new System.Drawing.Size(166, 174);
            this.gvStatus.TabIndex = 17;
            // 
            // gbMercadoria
            // 
            this.gbMercadoria.Controls.Add(this.gvProdutos);
            this.gbMercadoria.Location = new System.Drawing.Point(0, 211);
            this.gbMercadoria.Name = "gbMercadoria";
            this.gbMercadoria.Size = new System.Drawing.Size(349, 202);
            this.gbMercadoria.TabIndex = 22;
            this.gbMercadoria.TabStop = false;
            this.gbMercadoria.Text = "Mercadorias";
            // 
            // gvProdutos
            // 
            this.gvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ok});
            this.gvProdutos.Location = new System.Drawing.Point(3, 22);
            this.gvProdutos.Name = "gvProdutos";
            this.gvProdutos.RowHeadersVisible = false;
            this.gvProdutos.RowHeadersWidth = 10;
            this.gvProdutos.RowTemplate.Height = 25;
            this.gvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProdutos.Size = new System.Drawing.Size(337, 174);
            this.gvProdutos.TabIndex = 17;
            this.gvProdutos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProdutos_CellEnter);
            // 
            // ok
            // 
            this.ok.HeaderText = "OK";
            this.ok.MinimumWidth = 6;
            this.ok.Name = "ok";
            this.ok.Width = 30;
            // 
            // gbEntrega
            // 
            this.gbEntrega.Controls.Add(this.tbUF);
            this.gbEntrega.Controls.Add(this.lUF);
            this.gbEntrega.Controls.Add(this.tbCidade);
            this.gbEntrega.Controls.Add(this.lCidade);
            this.gbEntrega.Controls.Add(this.tbBairro);
            this.gbEntrega.Controls.Add(this.lBairro);
            this.gbEntrega.Controls.Add(this.tbComplemento);
            this.gbEntrega.Controls.Add(this.lComplemento);
            this.gbEntrega.Controls.Add(this.tbNumero);
            this.gbEntrega.Controls.Add(this.lNumero);
            this.gbEntrega.Controls.Add(this.tbRua);
            this.gbEntrega.Controls.Add(this.lRua);
            this.gbEntrega.Controls.Add(this.tbCEP);
            this.gbEntrega.Controls.Add(this.lCEP);
            this.gbEntrega.Location = new System.Drawing.Point(0, 100);
            this.gbEntrega.Name = "gbEntrega";
            this.gbEntrega.Size = new System.Drawing.Size(530, 105);
            this.gbEntrega.TabIndex = 21;
            this.gbEntrega.TabStop = false;
            this.gbEntrega.Text = "Endereço de Entrega";
            // 
            // tbUF
            // 
            this.tbUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUF.Location = new System.Drawing.Point(389, 77);
            this.tbUF.MaxLength = 2;
            this.tbUF.Name = "tbUF";
            this.tbUF.PlaceholderText = "UF";
            this.tbUF.Size = new System.Drawing.Size(40, 23);
            this.tbUF.TabIndex = 29;
            // 
            // lUF
            // 
            this.lUF.AutoSize = true;
            this.lUF.Location = new System.Drawing.Point(359, 80);
            this.lUF.Name = "lUF";
            this.lUF.Size = new System.Drawing.Size(24, 15);
            this.lUF.TabIndex = 28;
            this.lUF.Text = "UF:";
            // 
            // tbCidade
            // 
            this.tbCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCidade.Location = new System.Drawing.Point(55, 77);
            this.tbCidade.MaxLength = 50;
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.PlaceholderText = "Cidade";
            this.tbCidade.Size = new System.Drawing.Size(298, 23);
            this.tbCidade.TabIndex = 27;
            // 
            // lCidade
            // 
            this.lCidade.AutoSize = true;
            this.lCidade.Location = new System.Drawing.Point(2, 80);
            this.lCidade.Name = "lCidade";
            this.lCidade.Size = new System.Drawing.Size(47, 15);
            this.lCidade.TabIndex = 26;
            this.lCidade.Text = "Cidade:";
            // 
            // tbBairro
            // 
            this.tbBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbBairro.Location = new System.Drawing.Point(303, 48);
            this.tbBairro.MaxLength = 50;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.PlaceholderText = "Bairro";
            this.tbBairro.Size = new System.Drawing.Size(220, 23);
            this.tbBairro.TabIndex = 25;
            // 
            // lBairro
            // 
            this.lBairro.AutoSize = true;
            this.lBairro.Location = new System.Drawing.Point(256, 51);
            this.lBairro.Name = "lBairro";
            this.lBairro.Size = new System.Drawing.Size(41, 15);
            this.lBairro.TabIndex = 24;
            this.lBairro.Text = "Bairro:";
            // 
            // tbComplemento
            // 
            this.tbComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbComplemento.Location = new System.Drawing.Point(100, 48);
            this.tbComplemento.MaxLength = 50;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.PlaceholderText = "Complemento";
            this.tbComplemento.Size = new System.Drawing.Size(150, 23);
            this.tbComplemento.TabIndex = 23;
            // 
            // lComplemento
            // 
            this.lComplemento.AutoSize = true;
            this.lComplemento.Location = new System.Drawing.Point(7, 51);
            this.lComplemento.Name = "lComplemento";
            this.lComplemento.Size = new System.Drawing.Size(87, 15);
            this.lComplemento.TabIndex = 22;
            this.lComplemento.Text = "Complemento:";
            // 
            // tbNumero
            // 
            this.tbNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNumero.Location = new System.Drawing.Point(465, 19);
            this.tbNumero.MaxLength = 20;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.PlaceholderText = "Número";
            this.tbNumero.Size = new System.Drawing.Size(55, 23);
            this.tbNumero.TabIndex = 21;
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.Location = new System.Drawing.Point(435, 22);
            this.lNumero.Name = "lNumero";
            this.lNumero.Size = new System.Drawing.Size(24, 15);
            this.lNumero.TabIndex = 20;
            this.lNumero.Text = "Nº:";
            // 
            // tbRua
            // 
            this.tbRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRua.Location = new System.Drawing.Point(169, 19);
            this.tbRua.MaxLength = 100;
            this.tbRua.Name = "tbRua";
            this.tbRua.PlaceholderText = "Logradouro";
            this.tbRua.Size = new System.Drawing.Size(260, 23);
            this.tbRua.TabIndex = 19;
            // 
            // lRua
            // 
            this.lRua.AutoSize = true;
            this.lRua.Location = new System.Drawing.Point(133, 22);
            this.lRua.Name = "lRua";
            this.lRua.Size = new System.Drawing.Size(30, 15);
            this.lRua.TabIndex = 18;
            this.lRua.Text = "Rua:";
            // 
            // tbCEP
            // 
            this.tbCEP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCEP.Location = new System.Drawing.Point(47, 19);
            this.tbCEP.MaxLength = 10;
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.PlaceholderText = "CEP";
            this.tbCEP.Size = new System.Drawing.Size(80, 23);
            this.tbCEP.TabIndex = 17;
            // 
            // lCEP
            // 
            this.lCEP.AutoSize = true;
            this.lCEP.Location = new System.Drawing.Point(10, 22);
            this.lCEP.Name = "lCEP";
            this.lCEP.Size = new System.Drawing.Size(31, 15);
            this.lCEP.TabIndex = 16;
            this.lCEP.Text = "CEP:";
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(445, 419);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(75, 23);
            this.btnConcluir.TabIndex = 20;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lTotal.Location = new System.Drawing.Point(0, 419);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(147, 30);
            this.lTotal.TabIndex = 17;
            this.lTotal.Text = "Total: R$ 0,00";
            // 
            // FrmOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOferta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStatus)).EndInit();
            this.gbMercadoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).EndInit();
            this.gbEntrega.ResumeLayout(false);
            this.gbEntrega.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lFiltro;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button btnOfertar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.GroupBox gbEntrega;
        private System.Windows.Forms.TextBox tbUF;
        private System.Windows.Forms.Label lUF;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lCidade;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label lBairro;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label lComplemento;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label lRua;
        private System.Windows.Forms.TextBox tbCEP;
        private System.Windows.Forms.Label lCEP;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.DataGridView gvStatus;
        private System.Windows.Forms.GroupBox gbMercadoria;
        private System.Windows.Forms.DataGridView gvProdutos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ok;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label lSaldo;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label lTelefone;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.Label lCPF;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label label1;
    }
}