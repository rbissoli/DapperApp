using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperApp.ViewModels
{
    public class ListLivroAutorViewModel
    {
        public int LivroId { get; set; }
        public int AutorId { get; set; }

        public string NomeLivro { get; set; }
        public string NomeAutor { get; set; }
    }

    public class EditorLivroAutorViewModel
    {
        public int LivroId { get; set; }
        public int AutorId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Livros")]
        public SelectList LivrosOptions { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Autores")]
        public SelectList AutoresOptions { get; set; }
    }
}