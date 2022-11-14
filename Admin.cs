using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Admin
    {

        public String Username { get; set; }
        public String Matricula { get; set; }
        public String Cpf { get; set; }
        public String Senha { get; set; }

        public Admin()
        {
        }

        public Admin(string username, string matricula, string cpf, string senha)
        {
            Username = username;
            Matricula = matricula;
            Cpf = cpf;
            Senha = senha;
        }
    }
}
