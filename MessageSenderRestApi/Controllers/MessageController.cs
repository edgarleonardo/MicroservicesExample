using MicroservicesExample.Domain.Application.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MessageSenderRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MessageController : ControllerBase
    {
        private readonly IMessageRepository _messagePersistance;
        public MessageController(IMessageRepository messagePersistance)
        {
            this._messagePersistance = messagePersistance;
        }
       
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
