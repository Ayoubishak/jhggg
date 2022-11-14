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
    public partial class WindowMain : Form
    {
        public WindowMain()
        {
            InitializeComponent();

            new BancoDadosSimulado();
        }

        private void btnAdministracao_Click(object sender, EventArgs e)
        {

            LoginAdmin loginAdmin = LoginAdmin.GetInstance();
            loginAdmin.BringToFront();
            loginAdmin.Show();
        }

        private void btnEstudante_Click(object sender, EventArgs e)
        {
            LoginEstudante loginEstudante = new LoginEstudante();
            loginEstudante.BringToFront();
            loginEstudante.Show();
        }
    }
}
