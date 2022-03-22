using BiblioNetAPP.Models;
using BiblioNetAPP.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BookController :Controller
    {
        private readonly IRepositorieBook repositorieBook;
        public BookController(IRepositorieBook repositorieBook)
        {
            // this referencia a las variables locales del archivo
            this.repositorieBook = repositorieBook;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            book.IdAuthor = 1;

            repositorieBook.Create(book);

            return View();
        }
    }
}
