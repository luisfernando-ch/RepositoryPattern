using Code.RepositoryPattern.Repository.Base;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Code.RepositoryPattern.Api.Controllers.Base
{
    public abstract class ParentController<TModel, TRepository> : ControllerBase where TModel : class where TRepository : IRepository<TModel>
    {
        protected readonly TRepository Repository;

        public ParentController(TRepository repository)
        {
            this.Repository = repository;
        }

        [HttpGet]
        public IEnumerable<TModel> Get()
        {
            return Repository.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] TModel item)
        {
             Repository.Add(item);
        }        
    }
}