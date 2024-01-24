using Databaslagringuppgift.Repositories;
using Databaslagringuppgift.Tables;
using System;
using System.Collections.Generic;

namespace Databaslagringuppgift.Services
{
    internal class OrderService
    {
        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public Order GetOrderById(int orderId)
        {
            return _orderRepository.GetOrderById(orderId);
        }

        public void AddOrder(Order order)
        {
            _orderRepository.AddOrder(order);
        }

        public void UpdateOrder(Order order)
        {
            _orderRepository.UpdateOrder(order);
        }

        public void DeleteOrder(int orderId)
        {
            _orderRepository.DeleteOrder(orderId);
        }
    }
}
