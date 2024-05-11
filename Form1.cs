namespace FormularioInterativo
{
    public partial class Form1 : Form
    {    
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nome = Console.ReadLine();
        }

        private void Criar_click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string idade = txtIdade.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;

            FrmResultado cartao = new FrmResultado(
                nome,
                idade,
                telefone,
                email
            );

            cartao.ShowDialog();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
