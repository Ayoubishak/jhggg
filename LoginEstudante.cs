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
    public partial class LoginEstudante : Form
    {
        public LoginEstudante()
        {
            InitializeComponent();
        }

        private void llblCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

            WindowCadastroUser windowCadastroUser = WindowCadastroUser.GetInstance();
            windowCadastroUser.BringToFront();
            windowCadastroUser.Show();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Nome")
            {
                txtUser.Text = "";

                txtUser.ForeColor = Color.Black;
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

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.ForeColor = Color.Silver;
                txtUser.Text = "Nome";
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
    }
}
