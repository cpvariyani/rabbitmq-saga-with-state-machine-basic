using MassTransit;
using rabbitmq_message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stock_ms
{
    public class OrderCardNumberValidateConsumer :
      IConsumer<IOrderMessage>
    {
        public async Task Consume(ConsumeContext<IOrderMessage> context)
        {
            var data = context.Message;
            if (data.PaymentCardNumber != "test")
            {
                // invalid
            }
        }
    }
}
