using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Estudante
    {
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Numero { get; set; }

        public Estudante()
        {
        }

        public Estudante(string nome, string cpf, string numero)
        {
            Nome = nome;
            Cpf = cpf;
            Numero = numero;
        }
    }
}
