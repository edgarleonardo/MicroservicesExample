using MicroservicesExample.Domain.BaseEntity;
using MicroservicesExample.Domain.Users;

namespace MicroservicesExample.Domain.Messages
{
    public class Message : Entity
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public Message() : base()
        {
            User = new User();
        }
    }
}
