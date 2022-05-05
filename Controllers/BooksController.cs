using BookStore.Data.Repository;
using BookStoreAPI2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStore.Data.Models;

namespace BookStoreAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        /*public List<Book> books = new List<Book>()
        {
            new Book{Id = 1, Title="the kushal",Author="kush",PublicationYear=2012,CallNumber="k2022"},
            new Book{Id = 2, Title="the ku",Author="kuiih",PublicationYear=2002,CallNumber="k2022"},
            new Book{Id = 3, Title="the kul",Author="kuiyyih",PublicationYear=2012,CallNumber="k2022"},
            new Book{Id = 4, Title="the kual",Author="kusiiih",PublicationYear=2032,CallNumber="k2022"},
            new Book{Id = 5, Title="the kuhal",Author="kusyyyh",PublicationYear=2027,CallNumber="k2022"}

        };*/
        private BookRepository books = new BookRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books.GetAllBook();
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id )
        {
            //var book = books.FirstOrDefault(x => x.Id == id);
            var book = books.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }
    }
}
