using System;
using System.Windows.Forms;

namespace WeChip.Views
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Show();
        }

        private void btnOferta_Click(object sender, EventArgs e)
        {
            FrmOferta frmOferta = new FrmOferta();
            frmOferta.Show();
        }
    }
}
