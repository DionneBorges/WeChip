
namespace WeChip.Views
{
    partial class FrmCliente
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
            this.lCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lNome = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.lCPF = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.lTelefone = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.lSaldo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.Location = new System.Drawing.Point(12, 15);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(49, 15);
            this.lCodigo.TabIndex = 0;
            this.lCodigo.Text = "Código:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(67, 12);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.PlaceholderText = "Buscar cód.";
            this.tbCodigo.Size = new System.Drawing.Size(70, 23);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            this.tbCodigo.Leave += new System.EventHandler(this.tbCodigo_Leave);
            // 
            // tbNome
            // 
            this.tbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNome.Location = new System.Drawing.Point(67, 53);
            this.tbNome.MaxLength = 100;
            this.tbNome.Name = "tbNome";
            this.tbNome.PlaceholderText = "Nome do Cliente";
            this.tbNome.Size = new System.Drawing.Size(387, 23);
            this.tbNome.TabIndex = 3;
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Location = new System.Drawing.Point(18, 56);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(43, 15);
            this.lNome.TabIndex = 2;
            this.lNome.Text = "Nome:";
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(67, 91);
            this.tbCPF.MaxLength = 15;
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.PlaceholderText = "CPF";
            this.tbCPF.Size = new System.Drawing.Size(100, 23);
            this.tbCPF.TabIndex = 5;
            // 
            // lCPF
            // 
            this.lCPF.AutoSize = true;
            this.lCPF.Location = new System.Drawing.Point(30, 94);
            this.lCPF.Name = "lCPF";
            this.lCPF.Size = new System.Drawing.Size(31, 15);
            this.lCPF.TabIndex = 4;
            this.lCPF.Text = "CPF:";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(233, 91);
            this.tbTelefone.MaxLength = 15;
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.PlaceholderText = "Telefone";
            this.tbTelefone.Size = new System.Drawing.Size(100, 23);
            this.tbTelefone.TabIndex = 7;
            // 
            // lTelefone
            // 
            this.lTelefone.AutoSize = true;
            this.lTelefone.Location = new System.Drawing.Point(173, 94);
            this.lTelefone.Name = "lTelefone";
            this.lTelefone.Size = new System.Drawing.Size(54, 15);
            this.lTelefone.TabIndex = 6;
            this.lTelefone.Text = "Telefone:";
            // 
            // tbSaldo
            // 
            this.tbSaldo.BackColor = System.Drawing.Color.LimeGreen;
            this.tbSaldo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbSaldo.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSaldo.Location = new System.Drawing.Point(384, 91);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(70, 23);
            this.tbSaldo.TabIndex = 9;
            this.tbSaldo.Text = "0,00";
            this.tbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSaldo_KeyPress);
            this.tbSaldo.Leave += new System.EventHandler(this.tbSaldo_Leave);
            // 
            // lSaldo
            // 
            this.lSaldo.AutoSize = true;
            this.lSaldo.Location = new System.Drawing.Point(339, 94);
            this.lSaldo.Name = "lSaldo";
            this.lSaldo.Size = new System.Drawing.Size(39, 15);
            this.lSaldo.TabIndex = 8;
            this.lSaldo.Text = "Saldo:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(391, 148);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(310, 148);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(229, 148);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(148, 148);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lStatus
            // 
            this.lStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lStatus.Location = new System.Drawing.Point(148, 9);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(318, 21);
            this.lStatus.TabIndex = 14;
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 183);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.lSaldo);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.lTelefone);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.lCPF);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lNome);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCliente_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.Label lCPF;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label lTelefone;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label lSaldo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lStatus;
    }
}