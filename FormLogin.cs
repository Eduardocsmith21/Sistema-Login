using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string usu = texUsuario.Text;
            string sen = texSen.Text;
            if (CadastroUsuario.Login(usu, sen))
            {
                Close(); //Fechar Forms
            }
            else
            {
                MessageBox.Show("Acesso negado!");
                texUsuario.Text = "";
                texSen.Text = "";
                texUsuario.Focus();
                Close();
            }   
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
