using System;
using System.Collections.Generic;

namespace MobileStoreWebsiteV1._3.Models
{
    public partial class Model
    {
        public Model()
        {
            Products = new HashSet<Product>();
        }

        public int ModelId { get; set; }
        public string? ModelName { get; set; }
        public string? ModelVersion { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
