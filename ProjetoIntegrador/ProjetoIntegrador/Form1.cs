namespace ProjetoIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {

            Form2 primeiroAcesso = new Form2();
            primeiroAcesso.Show();

        }
    }
}