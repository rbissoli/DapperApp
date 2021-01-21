using DapperApp.Data.Repositories.Contracts;
using System.Web.Mvc;

namespace DapperApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAutorRepository repository;
        
        public HomeController(IAutorRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var autores = repository.GetAll();
            return View(autores);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}