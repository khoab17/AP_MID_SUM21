using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CategoryModel
    {
        public CategoryModel()
        {
            this.ProductModels = new HashSet<ProductModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductModel> ProductModels { get; set; }
    }
}
