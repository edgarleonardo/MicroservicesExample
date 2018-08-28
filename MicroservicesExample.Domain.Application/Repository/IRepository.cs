using MicroservicesExample.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesExample.Domain.Application.Repository
{
    public interface IRepository <T> where T : Entity
    {
        IQueryable<T> Query();
        Task<T> GetById(string id);
        Task<T> Save ( T model );
        Task<T> Update(string id,T model);

    }
}
