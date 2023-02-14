using KARTRIGE.DataBase;
using KARTRIGE.Models;
using KARTRIGE.Tools;
using System.Collections.Generic;
using System.Linq;


namespace KARTRIGE.ViewModels
{
    public class ListCabinetVM : BaseTools
    {
        public List<Cabinet> Cabinets { get; set; }
        //public Cabinet SelectedCabinet { get; set; }
        public CommandVM RemoveCabinet { get; set; } 

        public ListCabinetVM()
        {
            user05Context db = new user05Context();
            var cabinet = db.Cabinets.ToList();
            Cabinets = cabinet;
           
        }
    }
}
