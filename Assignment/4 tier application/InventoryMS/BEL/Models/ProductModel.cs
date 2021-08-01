using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public System.DateTime DeletedAt { get; set; }
        public string CreatedBy { get; set; }
        public byte[] UpdatedBy { get; set; }
        public byte[] DeletedBy { get; set; }

        public virtual CategoryModel CategoryModel { get; set; }

    }
}
