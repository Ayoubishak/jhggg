using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Autor
    {

        public string Nome { get; set; }
        public UInt64 Codigo { get; set; }

        public Autor()
        {
        }

        public Autor(string nome, ulong codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }
    }
}
