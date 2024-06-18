using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Order.API.Domain
{
    public class Orders
    {
        public Guid Id { get; private set; }
        public DateTime OrderDate { get; private set; }
        public decimal TotalAmount { get; private set; }

        private List<OrderItem> _orderItems = new List<OrderItem>();
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

        public Orders(Guid id, DateTime orderDate)
        {
            Id = id;
            OrderDate = orderDate;
        }

        public void AddOrderItem(OrderItem item)
        {
            _orderItems.Add(item);
            TotalAmount += item.TotalPrice;
        }

        // Other domain logic and methods...
    }

    public class OrderItem
    {
        public Guid Id { get; private set; }
        public string ProductName { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int Quantity { get; private set; }
        public decimal TotalPrice => UnitPrice * Quantity;

        public OrderItem(Guid id, string productName, decimal unitPrice, int quantity)
        {
            Id = id;
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }

}
