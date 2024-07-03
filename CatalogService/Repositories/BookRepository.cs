using CatalogService.Models;

namespace CatalogService.Repositories
{
    public class BookRepository
    {
        private readonly List<Book> _books = new List<Book>
        {
            new Book { Id = 1, Title = "Book 1", Author = "Author 1", Price = 9.99m },
            new Book { Id = 2, Title = "Book 2", Author = "Author 2", Price = 12.99m },
        };

        public IEnumerable<Book> GetAll() => _books;

        public Book GetById(int id) => _books.FirstOrDefault(b => b.Id == id);
    }
}
