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
        public IActionResult index()
        {
            var b = Repo.GetBooks();
            return View(b);
        }

        [Route("book/create")]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(Book book)
        {
            var b = Repo.Add(book);
            return RedirectToAction("index");
        }

        [Route("book/edit/{id}")]
        public IActionResult update(int id)
        {
            Book b = Repo.GetBook(id);
            return View(b);
        }

        [HttpPost]
        public IActionResult update(int id, Book book)
        {
            int b = Repo.Update(book);
            return RedirectToAction("index");
        }

        public IActionResult delete(int id)
        {
            Book b = Repo.GetBook(id);
            return View(b);
        }

        [HttpPost]
        public IActionResult confirmdelete(int id)
        {
            Repo.Delete(id);
            
            return RedirectToAction("index");
        }

        [Route("book/details/{id}")]
        public IActionResult details(int id)
        {
            Book b = Repo.GetBook(id);
            return View(b);
        }
    }
}