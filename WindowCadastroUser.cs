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
    public partial class WindowCadastroUser : Form
    {

        private static WindowCadastroUser instance;
        public WindowCadastroUser()
        {
            InitializeComponent();
        }

        public static WindowCadastroUser GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new WindowCadastroUser();
            }

            return instance;
        }
    }
}
