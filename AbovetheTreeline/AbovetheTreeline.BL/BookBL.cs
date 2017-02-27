using System;
using System.Collections.Generic;
using AbovetheTreeline.DataLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AbovetheTreeline.BL
{
    public class BookBL
    {
        
        private List<Book> books { get; set; }

        public  BookBL() {
            books = getbooks();
        }
        private List<Book> getbooks() {
            List<Book> Books = new List<Book>();
            for (int f= 0; f <= 50; f++) {
                BookDetails bookdetails = new BookDetails { Id = f + 1, isbn = "ISBN_" + f.ToString(), Genre = (f % 2 == 0 ? "M" : "F"), Year = (f % 2 == 0 ? DateTime.Today.Year : DateTime.Today.Year - 1), Price =(f % 2 == 0 ? (decimal) 100 : (decimal) 50.00) };
                Book book = new Book { Id = f+1, AuthorName = "AuthorName_" + f.ToString(), Title = "Title_" + f.ToString(),bookdetail= bookdetails };
                Books.Add(book);
            }

            return Books;
        }

        /// <summary>
        /// GetAllBooks
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAllBooks()
        {

            return books;

        }

        /// <summary>
        /// AllBooksBySelectedGender
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        public List<Book> AllBooksBySelectedGender(string gender)
        {

            return books.Where(x => x.bookdetail.Genre == gender).ToList() ;

        }

        /// <summary>
        /// AllBooksBySelectedPrice
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public List<Book> AllBooksBySelectedPrice(decimal price)
        {

            return books.Where(x => x.bookdetail.Price == price).ToList();

        }

        /// <summary>
        /// GetBookBySelectedISBN
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public Book GetBookBySelectedISBN(string isbn)
        {

            return books.FirstOrDefault(x => x.bookdetail.isbn == isbn);

        }


        /// <summary>
        /// GetBookBySelectedTitle
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public Book GetBookBySelectedTitle(string title)
        {

            return books.FirstOrDefault(x => x.Title == title);

        }

        public Book GetBookByID(int id)
        {

            return books.FirstOrDefault(x => x.Id == id);

        }

    }
}
