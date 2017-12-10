using Application.Interfaces.Infrastructure;
using Infrastructure.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Payment
{
    public class PaymentNotificationService : IPaymentNotificationService
    {
        // Note: these are hard coded to keep the code simple
        private const string AddressTemplate = "http://abc123.com/payment/products/{0}/notifyorderoccured/";
        private const string JsonTemplate = "{{\"quantity\": {0}}}";

        private readonly IHttpClientWrapper _client;

        public PaymentNotificationService(IHttpClientWrapper client)
        {
            _client = client;
        }

        public void NotifyOrderOcurred(int productId, int quantity)
        {
            var address = string.Format(AddressTemplate, productId);

            var json = string.Format(JsonTemplate, quantity);

            _client.Post(address, json);
        }
    }
}
