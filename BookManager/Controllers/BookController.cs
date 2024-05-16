using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookManager.Controllers
{
    public class BookController : Controller
    {
        // Static list to simulate a database
        private static List<Book> books = new List<Book>();

        // GET: Book
        public ActionResult Index()
        {
            return View(books);
        }

        // GET: Book/AddNew
        public ActionResult AddNew()
        {
            return View();
        }

        // POST: Book/AddNew
        [HttpPost]
        public ActionResult AddNew(Book book)
        {
            if (ModelState.IsValid)
            {
                book.IdBook = books.Count + 1;
                books.Add(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}