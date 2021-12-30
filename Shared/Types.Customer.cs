using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class Customer
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }
        public string Address { get; }

        public Customer(int id, string name, string email, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
