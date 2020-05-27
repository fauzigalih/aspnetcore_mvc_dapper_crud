using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore_mvc_dapper_crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_mvc_dapper_crud.Controllers
{
    public class BookController : Controller
    {
        private BookRepository Repo;
        public BookController(BookRepository repo)
        {
            this.Repo = repo;
        }

        [Route("book")]
        public IActionResult Index()
        {
            var b = Repo.GetBooks();
            return View(b);
        }

        [Route("book/create")]
        public IActionResult Create() => View();

        [HttpPost]
        [Route("book/create")]
        public IActionResult Create(Book book)
        {
            var b = Repo.Add(book);
            return RedirectToAction("Index");
        }

        [Route("book/update/{id}")]
        public IActionResult Update(int id)
        {
            Book b = Repo.GetBook(id);
            return View(b);
        }

        [HttpPost]
        [Route("book/update/{id}")]
        public IActionResult Update(int id, Book book)
        {
            int b = Repo.Update(book);
            return RedirectToAction("Index");
        }

        [Route("book/delete/{id}")]
        public IActionResult Delete(int id)
        {
            Book b = Repo.GetBook(id);
            return View(b);
        }

        [HttpPost]
        [Route("book/delete/{id}")]
        public IActionResult Confirmdelete(int id)
        {
            Repo.Delete(id);
            
            return RedirectToAction("index");
        }

        [Route("book/details/{id}")]
        public IActionResult Details(int id)
        {
            Book b = Repo.GetBook(id);
            return View(b);
        }
    }
}