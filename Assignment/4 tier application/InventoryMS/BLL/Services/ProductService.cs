using BEL;
using BLL.Services.MapperConfig;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductService
    {
        static ProductService()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSettings>());
        }

        //Get all the products Name
        public static List<string> GetProductNames()
        {
            return ProductRepo.GetProductNames();
        }

        //Get all the products service
        public static List<ProductModel> GetProducts()
        {
            var temp= ProductRepo.GetProducts();
            var data = AutoMapper.Mapper.Map<List<Product>, List<ProductModel>>(temp);
            return data;
        }

        //Add a new product
        public static void AddProduct(ProductModel p)
        {
            var data = AutoMapper.Mapper.Map<ProductModel, Product>(p);
            ProductRepo.AddProduct(data);

        }
    }
}
