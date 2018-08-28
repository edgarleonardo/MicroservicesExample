using MicroservicesExample.Domain.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesExample.Domain.Application.Repository
{
    public  interface IMessageRepository : IRepository<Message>
    {
    }
}
