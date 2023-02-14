using System;
using System.Collections.Generic;

namespace KARTRIGE.Models
{
    public partial class Device
    {
        public Device()
        {
            Orders = new HashSet<Order>();
        }

        public int DeviceId { get; set; }
        public string? NameDevice { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
