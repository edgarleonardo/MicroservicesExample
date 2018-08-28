using Domain.Persistance.DbContexts;
using MicroservicesExample.Domain.Application.Repository;
using MicroservicesExample.Domain.ChatChannel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesExample.Domain.Repository.Repository
{
    public class ChannelRepository : GeneryRepository<Channel>, IChannelRepository
    {
        public ChannelRepository(DomainChatDbContext db) : base(db)
        {

        }
    }
}
