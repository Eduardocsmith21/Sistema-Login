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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin log = new FormLogin();
            
            while(CadastroUsuario.Userlog == null) 
            {
                Visible = false;  //Não deixa formulario visivel no monitor
                log.ShowDialog();

                if(FormLogin.Cancelar == true)
                {
                    Application.Exit(); //Sai da aplicação
                    return; //Para sair do ciclo while
                }
            }
            label_boasVindas.Text = "Bem vindo(a) \n" + CadastroUsuario.Userlog.login;
            Visible= true;
        }
    }
}
