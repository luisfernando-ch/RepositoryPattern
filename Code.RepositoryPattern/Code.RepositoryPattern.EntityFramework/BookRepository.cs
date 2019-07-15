using Code.RepositoryPattern.Model;
using Code.RepositoryPattern.Repository;
using Code.RepositoryPattern.EntityFramework.Abstract;
using Code.RepositoryPattern.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Code.RepositoryPattern.EntityFramework
{
    public class BookRepository : Repository<Book>,IBookRepository
    {
        public ApplicationDatabaseContext ApplicationDatabaseContext
        { 
            get { return DatabaseContext as ApplicationDatabaseContext; }
        }

        public BookRepository(ApplicationDatabaseContext context) :base(context) { }

        public IEnumerable<Book> GetBooks()
        {
            return ApplicationDatabaseContext.Books.ToList();
        }

        public IEnumerable<Book> GetBooksByCurrentYear()
        {
            return ApplicationDatabaseContext.Books.Where(b=>b.Date.Year>=DateTime.Now.Year).ToList();
        }
    }
}
