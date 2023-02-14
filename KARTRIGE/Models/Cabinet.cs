using System;
using System.Collections.Generic;

namespace KARTRIGE.Models
{
    public partial class Cabinet
    {
        public Cabinet()
        {
            Orders = new HashSet<Order>();
        }

        public int CabinetId { get; set; }
        public int? NumberCabinet { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
