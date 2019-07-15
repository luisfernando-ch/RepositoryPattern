using Code.RepositoryPattern.Model;
using System.Collections.Generic;
using Code.RepositoryPattern.Repository.Base;

namespace Code.RepositoryPattern.Repository
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetBooks();
        IEnumerable<Book> GetBooksByCurrentYear();
    }
}