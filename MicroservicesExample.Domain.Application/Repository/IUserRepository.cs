using MicroservicesExample.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesExample.Domain.Application.Repository
{
    public  interface IUserRepository : IRepository<User>
    {
    }
}
