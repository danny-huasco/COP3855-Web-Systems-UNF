using Libreria.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Controllers
{
    public class BookController : Controller
    {
        // GET: BookController
        [Route("/Books")]
        public ActionResult Index()
        {
            var books = Book.GetBooks("./wwwroot/libros.json"); // Call the GetBooks method with the filename
            ViewBag.books = books; //making array of books available to the view

            return View();
        }

        // GET: BookController/Details/5
        [Route("/Books/{isbn}")]
        public ActionResult Details(string isbn)
        {
            var books = Book.GetBooks("./wwwroot/libros.json"); // Call the GetBooks method with the filename
            var book = books.Find(x => x.isbn == isbn); // Find the book with the given id
            ViewBag.book = book; //making book available to the view

            return View();
        }
    }
}
