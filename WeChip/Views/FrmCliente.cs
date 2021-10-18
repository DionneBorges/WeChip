using DB;
using Domain;
using System;
using System.Windows.Forms;

namespace WeChip.Views
{
    public partial class FrmCliente : Form
    {
        WeChipContext context;
        bool Alterando = false;
        public FrmCliente()
        {
            InitializeComponent();
            context = new WeChipContext();
            LimpaTela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpaTela()
        {
            tbCodigo.Text = "";
            tbNome.Text = "";
            tbCPF.Text = "";
            tbTelefone.Text = "";
            tbSaldo.Text = "0,00";
            tbSaldo.ReadOnly = Alterando;
            lStatus.Visible = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!Alterando)
            {
                Cliente cliente = new Cliente
                {
                    Nome = tbNome.Text,
                    CPF = tbCPF.Text,
                    Telefone = tbTelefone.Text,
                    Saldo = Convert.ToDecimal("0" + tbSaldo.Text),
                    StatusId = 1
                };

                try
                {
                    Validador.Validar(cliente);

                    context.Clientes.Add(cliente);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            } else
            {
                var cliente = context.Clientes.Find(Convert.ToInt32("0" + tbCodigo.Text));

                if (cliente != null)
                {
                    cliente.Nome = tbNome.Text;
                    cliente.CPF = tbCPF.Text;
                    cliente.Telefone = tbTelefone.Text;

                    try
                    {
                        Validador.Validar(cliente);
                        
                        context.Clientes.Update(cliente);
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                } else
                    MessageBox.Show($"Cliente {tbCodigo.Text} não localizado.");
            };

            context.SaveChanges();

            LimpaTela();
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            if (tbCodigo.Text != "")
            {
                Alterando = true;
                var cliente = context.Clientes.Find(Convert.ToInt32("0" + tbCodigo.Text));

                if (cliente != null)
                {
                    LimpaTela();

                    tbCodigo.Text = cliente.Id.ToString();
                    tbNome.Text = cliente.Nome;
                    tbCPF.Text = cliente.CPF;
                    tbTelefone.Text = cliente.Telefone;
                    tbSaldo.Text = cliente.Saldo.ToString("#,##0.00");

                    //lStatus.Visible = true;
                    //lStatus.Text = cliente.Status.Descricao;
                }
                else
                {
                    MessageBox.Show($"Cliente {tbCodigo.Text} não localizado.");
                    LimpaTela();
                    tbCodigo.Focus();
                }
            }
            else
                LimpaTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text != "")
            {
                var cliente = context.Clientes.Find(Convert.ToInt32("0" + tbCodigo.Text));

                if (cliente != null)
                {
                    context.Clientes.Remove(cliente);
                    context.SaveChanges();
                }
                else
                    MessageBox.Show($"Cliente {tbCodigo.Text} não localizado.");
                LimpaTela();
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void tbSaldo_Leave(object sender, EventArgs e)
        {
            tbSaldo.Text = decimal.Parse(tbSaldo.Text).ToString("N2");
        }

        private void FrmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);          
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Alterando = false;
            LimpaTela();
            tbNome.Focus();          
        }

        private void tbSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == 44))
                e.Handled = true;
        }
    }
}
