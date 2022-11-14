using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BancoDadosSimulado
    {
        public static List<Admin> Admins { get; set; }

        public BancoDadosSimulado()
        {
            Admins = new List<Admin>();
            Admins.Add(new Admin("douglas", "202200001", "99999999999", "senha"));
            Admins.Add(new Admin("davi", "202200002", "88888888888", "senha1"));
        }

        public static Boolean LoginAdmin(String username, String senha)
        {
            Boolean Verificacao = false;

            foreach (Admin admin in Admins)
            {
                if (username == admin.Username && senha == admin.Senha)
                {
                    Verificacao = true;
                }
            }

            return Verificacao;
        }
    }
}
