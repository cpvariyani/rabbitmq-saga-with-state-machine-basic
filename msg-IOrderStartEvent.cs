using System;

namespace rabbitmq_message.Events
{
    public interface IOrderStartEvent
    {
        public Guid OrderId { get;  }
        public string PaymentCardNumber { get;  }
        public string ProductName { get;  }
    }
}
