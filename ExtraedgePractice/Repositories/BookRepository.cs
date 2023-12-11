using ExtraedgePractice.Model;

namespace ExtraedgePractice.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext context;
        public BookRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public int AddBook(Book book)
        {
            int result = 0;
            context.Books.Add(book);
            book.IsActive = 1;
            result=context.SaveChanges();
            return result;
        }

        public int DeleteBook(int id)
        {
            int result = 0;
            var book = context.Books.Where(x=>x.Id == id).FirstOrDefault();
            if(book != null)
            {
                book.IsActive = 0;
                result=context.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            int result = 0;
            var book = context.Books.Where(x => x.IsActive == 1).ToList();
            return book;
        }

        public Book GetBookById(int id)
        {
            int result= 0;
            var book=context.Books.Where(x=>x.Id==id&&x.IsActive==1).FirstOrDefault();
            return book;
        }

        public int UpdateBook(Book book)
        {
            var result = 0;
            var books=context.Books.Where(x=>x.Id==book.Id).FirstOrDefault();
            if(books!= null)
            {
                books.Name=book.Name;
                books.Author=book.Author;
                books.Price=book.Price;
                books.IsActive=1;
                result=context.SaveChanges();
            }
            return result;
        }
    }
}
