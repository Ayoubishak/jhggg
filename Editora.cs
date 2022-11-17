using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Editora
    {

        public String Nome { get; set; }
        public UInt64 Codigo { get; set; }

        public Editora()
        {
        }

        public Editora(string nome, ulong codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }
    }
}
