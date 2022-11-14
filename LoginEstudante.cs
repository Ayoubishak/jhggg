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
    }
}
