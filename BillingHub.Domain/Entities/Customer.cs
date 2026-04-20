using System;
using System.Collections.Generic;
using System.Text;

namespace BillingHub.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public string Document { get; private set; }

        public Customer(Guid id, string name, string email, string document)
        {
            Id = id;
            Name = name;
            Email = email;
            Document = document;
        }
    }
}
