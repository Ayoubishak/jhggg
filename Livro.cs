using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Livro
    {

        public UInt64 Codigo { get; set; }
        public String Isbn { get; set; }
        public String Titulo { get; set; }
        public String Descricao { get; set; }
        public List<Autor> Autores { get; set; }
        public Editora Editora { get; set; }
        public DateTime Publicacao { get; set; }
        public Int16 Paginas { get; set; }
        public Int16 Edicao { get; set; }
        public DateTime Lancamento { get; set; }

        public Livro()
        {

            Autores = new List<Autor>();
        }

        public Livro(UInt64 codigo, string isbn, string titulo, string descricao, Editora editora, DateTime publicacao, Int16 paginas, Int16 edicao, DateTime lancamento)
        {
            Codigo = codigo;
            Isbn = isbn;
            Titulo = titulo;
            Descricao = descricao;
            Editora = editora;
            Publicacao = publicacao;
            Paginas = paginas;
            Edicao = edicao;
            Lancamento = lancamento;
        }

        public void AdicionarAutor(Autor autor)
        {
            Autores.Add(autor);
        }

        public override string ToString()
        {
            return $"{Autores}";
        }
    }
}
