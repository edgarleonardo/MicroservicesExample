using MicroservicesExample.Domain.BaseEntity;

namespace MicroservicesExample.Domain.Users
{
    public class User : Entity
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public User() : base()
        {
        }
    }
}
