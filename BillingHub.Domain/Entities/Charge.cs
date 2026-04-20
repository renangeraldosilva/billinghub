using System;
using System.Collections.Generic;
using System.Text;

namespace BillingHub.Domain.Entities
{
    public class Charge
    {
        public Guid Id { get; private set; }
        public Guid OrderId { get; private set; }
        public string ExternalReference { get; private set; }
        public decimal Amount { get; private set; }         
        public DateTime ExpiresAt { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Charge(Guid id, Guid orderId, string externalReference, decimal amount, DateTime expiresAt, DateTime createdAt)
        {
            Id = id;
            OrderId = orderId;
            ExternalReference = externalReference;
            Amount = amount;
            ExpiresAt = expiresAt;
            CreatedAt = createdAt;
        }
    }
}
