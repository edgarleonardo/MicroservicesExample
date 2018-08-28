using Domain.Persistance.DbContexts;
using MicroservicesExample.Domain.Application.Repository;
using MicroservicesExample.Domain.BaseEntity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MicroservicesExample.Domain.Repository.Repository
{
    public abstract class GeneryRepository<T> : IRepository<T> where T : Entity
    {
        protected DomainChatDbContext _dbContext { get; set; }
        protected GeneryRepository(DomainChatDbContext db)
        {
            _dbContext = db;
        }

        public async Task<T> GetById(string id)
        {
            return await _dbContext.FindAsync<T>(id);
        }

        public IQueryable<T> Query()
        {
            throw new NotImplementedException();
        }

        public async Task<T> Save(T model)
        {
            var changeTracking = _dbContext.Set<T>().Add(model);
            await _dbContext.SaveChangesAsync();
            return changeTracking.Entity;
        }

        public async Task<T> Update(string id, T model)
        {
            _dbContext.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return model;
        }
    }
}