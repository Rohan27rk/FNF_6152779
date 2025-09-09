using BookAuthorApi.Core.DTOs;
using BookAuthorApi.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//API Controllers are similar to controllers of MVC applications, but they are specifically designed to handle HTTP requests and responses for RESTful APIs. They typically return data in formats like JSON or XML rather than rendering views.
namespace BookAuthorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository repo)
        {
            this._bookRepository = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookRepository.GetAllBooksAsync();
            var model = books.Select(b => new BookDto(b.BookId, b.Title,b.BookPrice, b.AuthorId));
            return Ok(model);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(new BookDto(book.BookId, book.Title, book.BookPrice, book.AuthorId));
        }
        public async Task UpdateBook(BookDto book)
        {
            var existingBook = await _bookRepository.GetBookByIdAsync(book.BookId);
            if (existingBook == null)
            {
                NotFound();
            }
            existingBook.Title = book.Title;
            existingBook.BookPrice = book.BookPrice;
            existingBook.AuthorId = book.AuthorId;
            await _bookRepository.UpdateBookAsync(existingBook);
            NoContent();
        }
        public async Task<IActionResult> AddBook(BookDto book)
        {
            var newBook = new Core.Entities.Book
            {
                Title = book.Title,
                BookPrice = book.BookPrice,
                AuthorId = book.AuthorId,
                Author = new Core.Entities.Author
                {
                    Name = "Unknown" // Provide a default value for the required 'Name' property
                }
            };
            var addedBook = await _bookRepository.AddBookAsync(newBook);
            var addedBookDto = new BookDto(addedBook.BookId, addedBook.Title, addedBook.BookPrice, addedBook.AuthorId);
            return CreatedAtAction(nameof(GetBookById), new { id = addedBookDto.BookId }, addedBookDto);
        }
        public async Task RemoveBook(int id)
        {
            var existing = await _bookRepository.GetBookByIdAsync(id);
            if(existing != null)
            { 
                await _bookRepository.DeleteBookAsync(id);
            }
            else
            {
                NotFound();
            }
           
        }
    }
}