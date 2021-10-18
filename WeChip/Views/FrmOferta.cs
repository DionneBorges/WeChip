using DB;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WeChip.Views
{
    public partial class FrmOferta : Form
    {
        WeChipContext context;

        Cliente cliente;
        private decimal TotOferta;
        private bool TemHardware = false;

        public FrmOferta()
        {
            InitializeComponent();
            context = new WeChipContext();

            cbFiltro.SelectedIndex = 0;

            ModoBusca();
        }

        private void CargaStatus()
        {
            var status = context.Status.Where(s => s.Id > 1).OrderBy(s => s.Id).ToList();

            gvStatus.Rows.Clear();
            gvStatus.ColumnCount = 2;
            gvStatus.Columns[0].Name = "Id";
            gvStatus.Columns[0].Visible = false;
            gvStatus.Columns[1].Name = "Descrição";
            gvStatus.Columns[1].Width = 145;

            foreach (var state in status)
                gvStatus.Rows.Add(new string[] { state.Id.ToString(), state.Descricao });
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuscaCliente()
        {
            cbBusca.Items.Clear();
            if (cbBusca.Text != "")
            {
                var clientes = new List<Cliente>();

                if (cbFiltro.SelectedIndex == 0)
                    clientes = context.Clientes.Where(c => c.Nome.Contains(cbBusca.Text) && !c.Status.Finaliza).OrderBy(c => c.Nome).ToList();
                else
                    clientes = context.Clientes.Where(c => c.CPF.Contains(cbBusca.Text) && !c.Status.Finaliza).OrderBy(c => c.Nome).ToList();

                foreach (Cliente c in clientes)
                    cbBusca.Items.Add(c);
                
                cbBusca.Select(cbBusca.Text.Length, 0); 
            }
        }

        private void CarregaProdutos()
        {
            var produtos = context.Produtos.OrderBy(p => p.Descricao).ToList();

            gvProdutos.DataSource = produtos;

            gvProdutos.Columns[1].Visible = false;
            gvProdutos.Columns[2].Width = 125;
            gvProdutos.Columns[3].Width = 60;
            gvProdutos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvProdutos.Columns[4].Width = 80;
            gvProdutos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnOfertar_Click(object sender, EventArgs e)
        {
            if (((Cliente)cbBusca.SelectedItem).Id > 0)
            {
                cliente = context.Clientes.Include(c => c.Status).FirstOrDefault(c => c.Id == ((Cliente)cbBusca.SelectedItem).Id);

                tbNome.Text = cliente.Nome;
                tbTelefone.Text = cliente.Telefone;
                tbCPF.Text = cliente.CPF;
                tbSaldo.Text = cliente.Saldo.ToString("N2");
                lStatus.Text = cliente.Status.Descricao;


                CarregaProdutos();
                CargaStatus();

                //Modo Ofertar
                panel1.Enabled = false;
                panel2.Enabled = true;
            }
            else
                MessageBox.Show("Selecione o cliente para continuar.");
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            //Pego a quantidade de itens selecionada
            int qtdLinhas = VerificaSelecionados();

            //Cliente aceitou a oferta
            if (Convert.ToInt32(gvStatus.CurrentRow.Cells[0].Value) == 9)
            {
                //Foi selecionado algum item
                if (qtdLinhas > 0)
                {
                    //possui saldo suficiente
                    if (TotOferta <= cliente.Saldo)
                    {
                        //Se algum item selecionado for do tipo HARDWARE, obriga o preenchimento do endereço
                        if ((TemHardware) && ((tbBairro.Text == "") || (tbCEP.Text == "") || (tbCidade.Text == "") || (tbNumero.Text == "") || (tbRua.Text == "") || (tbUF.Text == "")))
                        {
                            MessageBox.Show("Endereço incompleto, por favor verifique.");
                            return;
                        }

                        //Cria a Oferta para o cliente
                        Oferta oferta = new Oferta()
                        {
                            CEP = tbCEP.Text,
                            Rua = tbRua.Text,
                            Numero = tbNumero.Text,
                            Complemento = tbComplemento.Text,
                            Bairro = tbBairro.Text,
                            Cidade = tbCidade.Text,
                            Estado = tbUF.Text,
                            Total = TotOferta,
                            Cliente = cliente
                        };
                        context.Ofertas.Add(oferta);

                        //Adiciona os itens da oferta
                        for (int i = gvProdutos.RowCount - 1; i >= 0; i--)
                        {
                            if (Convert.ToBoolean(gvProdutos.Rows[i].Cells[0].Value) == true)
                            {
                                OfertaItem item = new OfertaItem()
                                {
                                    Oferta = oferta,
                                    ProdutoId = Convert.ToInt32(gvProdutos.Rows[i].Cells[1].Value)
                                };

                                context.OfertaItems.Add(item);
                            }
                        }

                        //Altera o status do cliente e debita o saldo
                        cliente.StatusId = Convert.ToInt32(gvStatus.CurrentRow.Cells[0].Value);
                        cliente.Nome = tbNome.Text;
                        cliente.Telefone = tbTelefone.Text;
                        cliente.Saldo += -TotOferta;

                        //Salva as alterações
                        context.SaveChanges();
                        ModoBusca();
                    }
                    else
                        MessageBox.Show($"O cliente não possui saldo sufuciente. \nSaldo: R$ { cliente.Saldo.ToString("N2")}");
                }
                else
                    MessageBox.Show("Nenhum item da oferta foi selecionado");
            }
            else
            {
                if (qtdLinhas == 0)
                {
                    //Altera o status do cliente
                    cliente.StatusId = Convert.ToInt32(gvStatus.CurrentRow.Cells[0].Value);
                    cliente.Nome = tbNome.Text;
                    cliente.Telefone = tbTelefone.Text;

                    context.SaveChanges();
                    ModoBusca();
                }
                else
                    MessageBox.Show("Se o cliente não aceitou a oferta, por favor desmarque os itens selecionados");
            }
        }
        private void ModoBusca()
        {
            //Deixa a tela em modo de seleção de cliente
            gvStatus.Rows.Clear();
            cliente = null;
            cbBusca.Text = "";
            tbNome.Text = "";
            tbSaldo.Text = "0,00";
            tbTelefone.Text = "";
            tbCPF.Text = "";
            tbBairro.Text = "";
            tbCEP.Text = "";
            tbCidade.Text = "";
            tbComplemento.Text = "";
            tbNumero.Text = "";
            tbRua.Text = "";
            tbUF.Text = "";
            lTotal.Text = $"Total: R$ 0,00";
            lStatus.Text = "";
            panel1.Enabled = true;
            panel2.Enabled = false;
            BuscaCliente();
            cbBusca.Focus();
        }

        private int VerificaSelecionados()
        {
            int qtdLinhas = 0;
            if (gvProdutos.CurrentCell.RowIndex > 0)
            {
                TemHardware = false;
                TotOferta = 0;
                qtdLinhas = gvProdutos.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells[0].Value) == true).Count();

                if (qtdLinhas > 0)
                {
                    for (int i = gvProdutos.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = gvProdutos.Rows[i];
                        if (Convert.ToBoolean(row.Cells[0].Value) == true)
                        {
                            TotOferta += Convert.ToDecimal(row.Cells[3].Value);

                            if ((!TemHardware) && (Convert.ToString(row.Cells[4].Value).ToUpper() == "HARDWARE"))
                                TemHardware = true;
                        }
                    }
                }
            }

            lTotal.Text = $"Total: R$ {TotOferta.ToString("N2")}";
            return qtdLinhas;
        }

        private void gvProdutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            VerificaSelecionados();
        }

        private void cbBusca_KeyUp(object sender, KeyEventArgs e)
        {
            BuscaCliente();
        }

        private void cbBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cbBusca_Enter(object sender, EventArgs e)
        {
            cbBusca.DroppedDown = true;
        }
    }
};