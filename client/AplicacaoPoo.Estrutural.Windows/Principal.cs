namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirFormDolar_Click(object sender, EventArgs e)
        {
            var form = new frmConversorMoeda();
            form.Show();
        }

        private void btnAbrirFormComissao_Click(object sender, EventArgs e)
        {
            var form = new frmComissao();
            form.Show();
        }

        private void conversorDeMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmConversorMoeda();
            form.MdiParent = this;
            form.Show();
        }

        private void comissionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmComissao();
            form.MdiParent = this;
            form.Show();
        }
    } 
} 