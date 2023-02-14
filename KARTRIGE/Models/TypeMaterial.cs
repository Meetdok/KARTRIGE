using System;
using System.Collections.Generic;

namespace KARTRIGE.Models
{
    public partial class TypeMaterial
    {
        public TypeMaterial()
        {
            Materials = new HashSet<Material>();
        }

        public int TypeMaterialsId { get; set; }
        public string? NameTypeMaterials { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
    }
}
