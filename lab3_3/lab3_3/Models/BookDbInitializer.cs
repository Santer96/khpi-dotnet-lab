using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace lab3_3.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Name 1", Author = "Author 1", Price = 250 });
            db.Books.Add(new Book { Name = "Name 2", Author = "Author 2", Price = 200 });
            db.Books.Add(new Book { Name = "Name 3", Author = "Author 3", Price = 150 });

            base.Seed(db);
        }
    }
}
