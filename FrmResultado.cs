using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioInterativo
{
    public partial class FrmResultado : Form
    {
        string nome;
        string idade;
        string telefone;
        string email;
        public FrmResultado(string _nome, string _idade, string _telefone, string _email)
        {
            InitializeComponent();
            nome = _nome;
            idade = _idade;
            telefone = _telefone;
            email = _email;
        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {
            lblNome1.Text = nome.ToString();
            lblIdade1.Text = idade.ToString();
            lblTelefone1.Text = telefone.ToString();
            lblEmail1.Text = email.ToString();
        }

    }
}
