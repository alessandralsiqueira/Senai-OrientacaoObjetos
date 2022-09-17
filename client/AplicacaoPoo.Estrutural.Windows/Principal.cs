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
            var form = new frmCotacaoDolar();
            form.Show();
        }

        private void btnAbrirFormComissao_Click(object sender, EventArgs e)
        {
            var form = new frmComissao();
            form.Show();
        }
    } 
} 