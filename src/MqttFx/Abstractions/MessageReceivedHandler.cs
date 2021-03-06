﻿using System;

namespace MqttFx
{
    public class MessageReceivedHandler : IMessageReceivedHandler
    {
        private readonly Action<Message> _handler;

        public MessageReceivedHandler(Action<Message> handler)
        {
            _handler = handler;
        }

        public void OnMesage(Message message)
        {
            _handler(message);
        }
    }
}
