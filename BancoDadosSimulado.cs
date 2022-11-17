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
        public static List<Autor> Autors { get; set; }
        public static List<Editora> Editoras { get; set; }
        public static List<Livro> Livros { get; set; }

        public BancoDadosSimulado()
        {
            Admins = new List<Admin>();
            Admins.Add(new Admin("douglas", "202200001", "99999999999", "senha"));
            Admins.Add(new Admin("davi", "202200002", "88888888888", "senha1"));

            Autors = new List<Autor>();
            Autor homero = new Autor("Homero", 928001);
            Autor harriet = new Autor("Harriet Beecher Stowe", 1811001);
            Autor mary = new Autor("Mary Shelley", 1797001);
            Autor orwell = new Autor("George Orwell", 1903001);
            Autor achebe = new Autor("Chinua Achebe", 1930001);
            Autors.Add(homero);
            Autors.Add(harriet);
            Autors.Add(mary);
            Autors.Add(orwell);
            Autors.Add(achebe);

            Editoras = new List<Editora>();
            Editora atica = new Editora("Ática", 2022000001);

            Livros = new List<Livro>();
            Livros.Add(new Livro(7890001, "978-8508086924", "Odisseia", "Odisseia é um dos dois principais poemas épicos da Grécia Antiga, atribuídos a Homero. É uma sequência da Ilíada, outra obra creditada ao autor, e é um poema fundamental no cânone ocidental. Historicamente, é a segunda — a primeira sendo a própria Ilíada — obra da literatura ocidental.", atica, DateTime.Parse("2019-12-3"), 136, 1, DateTime.Parse("2019-12-3")));
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
