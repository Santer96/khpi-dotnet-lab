using lab3_3.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace lab3_3.Controllers
{
    public class HomeController : Controller
    {

        BookContext db = new BookContext();

        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books;
            ViewBag.Books = books;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int Id)
        {
            ViewBag.BookId = Id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = System.DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Thank you, " + purchase.Person + ", for buying!";
        }
    }
}
