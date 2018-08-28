using MicroservicesExample.Domain.ChatChannel;
using MicroservicesExample.Domain.Messages;

namespace MicroservicesExample.Domain.Agregate
{
    public class InformationToSent
    {
        public Message Message { get; set; }
        public Channel Channel { get; set; }
        public InformationToSent()
        {
            Message = new Message();
            Channel = new Channel();
        }
    }
}