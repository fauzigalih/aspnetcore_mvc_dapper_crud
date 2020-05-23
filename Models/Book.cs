using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore_mvc_dapper_crud.Models
{
    public class Book
    {
        [Key]
        [DisplayName("Book ID")]
        public int ID { get; set; }
        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }
        [Required]
        [DisplayName("Author")]
        public string Author { get; set; }
        [Required]
        [DisplayName("Date Published")]
        public DateTime PublishedDate { get; set; }
    }
    public class BookRepository
    {
        private DbConn DB;

        public BookRepository(DbConn dbConn)
        {
            this.DB = dbConn;
        }

        public IEnumerable<Book> GetBooks()
        {
            var books = DB.Connection.Query<Book>("SELECT * FROM book");
            return books;
        }

        public Book GetBook(int id)
        {
            var books = DB.Connection.QuerySingle<Book>("SELECT * FROM book WHERE id=@id", new { id });
            return books;
        }

        public int Add(Book newbook)
        {
            var ind = DB.Connection.Execute("INSERT INTO book(title,author,publisheddate) VALUES (@title,@author,@publisheddate)", newbook);
            return ind;
        }

        public int Delete(int id)
        {
            var ind = DB.Connection.Execute("DELETE FROM book WHERE id=@id", new { id });
            return ind;
        }

        public int Update(Book book)
        {
            var ind = DB.Connection.Execute("UPDATE book  SET title=@title, author=@author, publisheddate=@publisheddate WHERE id=@id", book);
            return ind;
        }
    }
    
}
