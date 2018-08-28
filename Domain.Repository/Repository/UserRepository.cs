using Domain.Persistance.DbContexts;
using MicroservicesExample.Domain.Application.Repository;
using MicroservicesExample.Domain.Users;

namespace MicroservicesExample.Domain.Repository.Repository
{
    public class UserRepository : GeneryRepository<User>, IUserRepository
    {
        public UserRepository(DomainChatDbContext db) : base(db)
        {

        }
    }
}
