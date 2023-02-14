using KARTRIGE.DataBase;
using KARTRIGE.Models;
using KARTRIGE.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARTRIGE.ViewModels
{
    public class OrderVM : BaseTools
    {

        public List<Cabinet> CabinetSelect { get; set; }
        public List<Device> DeviceSelect { get; set; }
       public List<OrderType> OrderTypeSelect { get; set; }

        public OrderVM()
        {
            user05Context db = new user05Context();
            var cabinet = db.Cabinets.ToList();            
            var device = db.Devices.ToList();
            var order_type = db.OrderTypes.ToList();
            CabinetSelect = cabinet;
            DeviceSelect = device;
            OrderTypeSelect = order_type;
        }
    }
}
