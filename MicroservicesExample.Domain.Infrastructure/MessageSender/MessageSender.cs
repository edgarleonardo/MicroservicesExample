using MicroservicesExample.Domain.Agregate;
using MicroservicesExample.Domain.Application.MessageSender;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesExample.Domain.Infrastructure.MessageSender
{
    public class MessageSender : IMessageSender
    {
        public void SendMessage(InformationToSent message)
        {
            throw new NotImplementedException();
        }
    }
}
