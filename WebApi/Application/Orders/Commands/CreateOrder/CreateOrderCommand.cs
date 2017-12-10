using Application.Interfaces.Infrastructure;
using Application.Interfaces.Persistence;
using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Orders.Commands.CreateOrder
{
    public class CreateOrderCommand : ICreateOrderCommand
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaymentNotificationService _payment;

        public CreateOrderCommand(
            IOrderRepository orderRepository,
            IUnitOfWork unitOfWork,
            IPaymentNotificationService payment)
        {
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
            _payment = payment;
        }

        public void Execute(CreateOrderModel model)
        {
            //var order = _factory.Create(date,
            //                            customer,
            //                            employee,
            //                            product,
            //                            quantity);

            Order order = new Order() {  };

            _orderRepository.Add(order);

            _unitOfWork.Save();

            //_payment.NotifyOrderOcurred();
        }
    }
}
