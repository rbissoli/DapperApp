using DapperApp.Data.Repositories;
using DapperApp.Data.Repositories.Contracts;
using DapperApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperApp.Controllers
{
    public class LivroAutorController : Controller
    {
        private readonly ILivroAutorRepository _repository;

        public LivroAutorController(ILivroAutorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            //var livroAutorViewModel = new List<LivroAutorViewModel>();
            //var autoresLivros = _repository.GetAll();
            //AutorRepository autoresOptions = new AutorRepository();
            //LivroRepository livrosOptions = new LivroRepository();

            ////id, id, nome, nome - viewmodel

            //foreach (var autorLivro in autoresLivros)
            //{
            //    livroAutorViewModel.Add(new LivroAutorViewModel
            //    {
            //        AutorId = autorLivro.Autor_Id,
            //        LivroId = autorLivro.Livro_Id,
            //        AutoresOptions = new SelectList(autoresOptions.GetAll(), "Id", "Nome"),
            //        LivrosOptions = new SelectList(livrosOptions.GetAll(), "Id", "Nome")
            //    });
            //}

            //id, id - domain
            //join
            //id, id, nome, nome - viewmodel

            var livrosAutores = new LivroAutorRepository().GetAll(); //domain

            var livroAutorViewModel = new List<ListLivroAutorViewModel>();

            foreach (var autorLivro in livrosAutores)
            {
                livroAutorViewModel.Add(
                     new ListLivroAutorViewModel { AutorId = autorLivro.Autor_Id, LivroId = autorLivro.Livro_Id }
                    );
            }


            return View(livroAutorViewModel);
        }
    }
}