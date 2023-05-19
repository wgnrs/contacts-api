using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
         TEntity GetById(int id);
         IEnumerable<TEntity> GetAll();
         void Save(TEntity entity);    
    }
}