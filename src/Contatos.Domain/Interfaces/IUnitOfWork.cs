using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}