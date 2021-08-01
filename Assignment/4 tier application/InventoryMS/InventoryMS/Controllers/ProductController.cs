using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InventoryMS.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product/Names

        [Route("api/Product/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return ProductService.GetProductNames();
        }

        //Get api/Products returning all the products.

        [Route("api/Products")]
        [HttpGet]
        public List<ProductModel> GetProduct()
        {
            return ProductService.GetProducts();
        }

        //Post Add product
        [Route("api/Product/Add")]
        [HttpPost]
        public void AddProduct(ProductModel p)
        {
            ProductService.AddProduct(p);
        }
    }
}
