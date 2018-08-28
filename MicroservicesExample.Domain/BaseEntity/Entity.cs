using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesExample.Domain.BaseEntity
{
    public abstract class Entity
    {
        public string Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Entity()
        {
            UpdateDate = DateTime.Now;
            CreationDate = DateTime.Now;
        }
    }
}
