using MicroservicesExample.Domain.BaseEntity;
using MicroservicesExample.Domain.Users;
using System.Collections.Generic;

namespace MicroservicesExample.Domain.ChatChannel
{
    public class Channel : Entity
    {
        public string ChannelName { get; set; }
        public List<ChannelUsers> ChannelUsers { get; set; }
        public User UserOwner { get; set; }
        public string UserId { get; set; }
        public Channel() : base()
        {
            ChannelUsers = new List<ChannelUsers>();
            UserOwner = new User();
        }
    }
}
