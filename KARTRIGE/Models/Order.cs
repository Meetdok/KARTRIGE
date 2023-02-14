using System;
using System.Collections.Generic;

namespace KARTRIGE.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? IdorderType { get; set; }
        public int? IdorderDevice { get; set; }
        public int? Cost { get; set; }
        public int? CabinetId { get; set; }
        public int? MaterialsId { get; set; }

        public virtual Cabinet? Cabinet { get; set; }
        public virtual Device? IdorderDeviceNavigation { get; set; }
        public virtual OrderType? IdorderTypeNavigation { get; set; }
        public virtual Material? Materials { get; set; }
    }
}
