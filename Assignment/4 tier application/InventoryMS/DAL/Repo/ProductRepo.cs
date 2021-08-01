using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static IMSEntities context;
        static ProductRepo()
        {
            context = new IMSEntities();
        }

        public static List<string> GetProductNames()
        {
            var data = context.Products.Select(x => x.Name).ToList();
            return data;
        }
        public static List<Product> GetProducts()
        {
            var data = context.Products.ToList();
            return data;
        }
        public static void AddProduct(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }
    }
}
