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
    public class CabinetEditVM : BaseTools
    {
        public Cabinet EditCabinet { get; set; } = new Cabinet();  
        public Cabinet SelectedCabinet { get; set; }
        public CommandVM SaveCabinet { get; set; }
        public CommandVM DeleteCabinet { get; set; }
        public List<Cabinet> CabinetSelect { get; set; }              

        public CabinetEditVM()
        {
            user05Context db = new user05Context();
            var cabinet = db.Cabinets.ToList();                      
            CabinetSelect = cabinet;

            DeleteCabinet = new CommandVM(() => {
                var model = user05Context.GetInstance();                
                model.Cabinets.Remove(SelectedCabinet);
                model.SaveChanges();
            });

            SaveCabinet = new CommandVM(() => {
                var model = user05Context.GetInstance();
                if (EditCabinet.CabinetId == 0)
                    model.Add(EditCabinet);
                else
                    model.Update(EditCabinet);
                model.SaveChanges();                               
            });
        }
      
    }
}
