using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Models
{
    public class Livros
    {
        [Key]
        public string Id_Livro { get; set; }

        public string Nome { get; set; }

        public string Autor { get; set; }

        public int Ano { get; set; }

        public string Categoria { get; set; }

        public string Editora { get; set; }

        public int Paginas { get; set; }

    }
}