using System;
using System.Collections.Generic;

namespace KARTRIGE.Models
{
    public partial class OrderType
    {
        public OrderType()
        {
            Orders = new HashSet<Order>();
        }

        public int OrderTypeId { get; set; }
        public string? NameOfOrder { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
