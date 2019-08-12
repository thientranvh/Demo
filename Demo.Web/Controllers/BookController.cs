using System.Dynamic;
using Demo.Repository;
using Demo.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly UnitOfWork _UoW;

        public BookController(IUnitOfWork uow)
        {
            this._UoW = uow as UnitOfWork;
        }
        // GET
        public IActionResult Index()
        {
            dynamic model = new ExpandoObject();
            model.Books = this._UoW.BookRepository.GetTopBookInMonth(2019, 5);
            return View("BookDetailView",model);
        }
    }
}