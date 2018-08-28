using MicroservicesExample.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesExample.Domain.ChatChannel
{
    public class ChannelUsers
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public string ChannelId { get; set; }
        public Channel Channel { get; set; }
        public ChannelUsers()
        {
            Channel = new Channel();
            User = new User();
        }
        
    }
}
