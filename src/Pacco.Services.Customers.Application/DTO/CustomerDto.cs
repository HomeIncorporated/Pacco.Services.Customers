using System;
using System.Collections.Generic;

namespace Pacco.Services.Customers.Application.DTO
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public bool IsVip { get; set; }
        public bool RegistrationCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<Guid> CompletedOrders { get; set; }
    }
}