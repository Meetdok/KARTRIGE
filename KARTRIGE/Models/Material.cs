using System;
using System.Collections.Generic;

namespace KARTRIGE.Models
{
    public partial class Material
    {
        public Material()
        {
            Orders = new HashSet<Order>();
        }

        public int MaterialsId { get; set; }
        public string? NameMaterials { get; set; }
        public string? TypeMaterials { get; set; }
        public int? CostMaterials { get; set; }
        public int? TypeMaterialsId { get; set; }

        public virtual TypeMaterial? TypeMaterialsNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
