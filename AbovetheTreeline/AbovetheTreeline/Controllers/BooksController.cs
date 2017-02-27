using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AbovetheTreeline.DataLayer;
using AbovetheTreeline.BL;
namespace AbovetheTreeline.Controllers
{
    public class BooksController : ApiController
    {
        private BookBL books = new BookBL();
        // GET api/books
        public IEnumerable<Book> Get()
        { 
            return books.GetAllBooks();
        }

        // GET api/books?gender=F
        public IEnumerable<Book> Get(string gender)
        {
            return books.AllBooksBySelectedGender(gender);
        }
        // GET api/books?price=100
        public  IEnumerable<Book> Get(decimal price)
        {
            return books.AllBooksBySelectedPrice(price);
        }


        // GET api/books/1
        public IHttpActionResult Getbook(int id)
        {
            return Ok(books.GetBookByID(id));
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
