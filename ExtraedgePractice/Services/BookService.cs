using ExtraedgePractice.Model;
using ExtraedgePractice.Repositories;

namespace ExtraedgePractice.Services
{
    public class BookService : IBookService
    { private readonly IBookRepository repository;
        public BookService(IBookRepository repository)
        {
            this.repository = repository;   
        }
        public int AddBook(Book book)
        {
          return repository.AddBook(book);
        }

        public int DeleteBook(int id)
        {
            return repository.DeleteBook(id);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return repository.GetAllBooks();
        }

        public Book GetBookById(int id)
        {
            return repository.GetBookById(id);
        }

        public int UpdateBook(Book book)
        {
            return repository.UpdateBook(book);
        }
    }
}
