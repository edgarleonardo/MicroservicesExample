using Domain.Persistance.DbContexts;
using MicroservicesExample.Domain.Application.Repository;
using MicroservicesExample.Domain.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesExample.Domain.Repository.Repository
{
    public class MessageRepository : GeneryRepository<Message>, IMessageRepository
    {
        public MessageRepository(DomainChatDbContext db) : base(db)
        {

        }
    }
}
