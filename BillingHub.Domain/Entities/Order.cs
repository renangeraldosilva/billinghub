using System;
using System.Collections.Generic;
using System.Text;

namespace BillingHub.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public Guid CustomerId { get; private set; }
        public decimal Amount { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Order(Guid id, Guid customerId, decimal amount, string description, DateTime createdAt)
        {
            Id = id;
            CustomerId = customerId;
            Amount = amount;
            Description = description;
            CreatedAt = createdAt;
        }
    }
}
