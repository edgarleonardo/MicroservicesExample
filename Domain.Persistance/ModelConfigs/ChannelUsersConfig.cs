using MicroservicesExample.Domain.ChatChannel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Persistance.ModelConfigs
{
    public class ChannelUsersConfig : IEntityTypeConfiguration<ChannelUsers>
    {

        public void Configure(EntityTypeBuilder<ChannelUsers> builder)
        {
            builder.HasKey(s => new { s.ChannelId, s.UserId });
        }
    }
}
