using Code.RepositoryPattern.Api.Controllers.Base;
using Code.RepositoryPattern.EntityFramework;
using Code.RepositoryPattern.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Code.RepositoryPattern.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ParentController<Book,BookRepository>
    {
        public BooksController(BookRepository bookRepository) : base (bookRepository)
        {
        }

        [Route("[action]")]
        [HttpGet]
        public IEnumerable<Book> ByCurrentYear()
        {
            return base.Repository.GetBooksByCurrentYear();
        }

        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return base.Repository.Get(id);
        }
    }
}
