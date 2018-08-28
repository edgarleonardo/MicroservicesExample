using MicroservicesExample.Domain.Agregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesExample.Domain.Application.MessageSender
{
    public interface IMessageSender
    {
        void SendMessage(InformationToSent message);
    }
}
