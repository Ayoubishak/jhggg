using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginAdmin : Form
    {

        private static LoginAdmin instance;
        public LoginAdmin()
        {
            InitializeComponent();
        }

        public static LoginAdmin GetInstance()
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new LoginAdmin();
            }

            return instance;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {

            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";

                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {

            if (txtUsername.Text == "")
            {
                txtUsername.ForeColor = Color.Silver;
                txtUsername.Text = "Username";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.UseSystemPasswordChar = true;
                txtSenha.Text = "";

                txtSenha.ForeColor = Color.Black;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.UseSystemPasswordChar = false;
                txtSenha.ForeColor = Color.Silver;
                txtSenha.Text = "Senha";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (BancoDadosSimulado.LoginAdmin(txtUsername.Text, txtSenha.Text) == true)
            {

            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválido.");
            }
        }
    }
}
