using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;

namespace InventoryMS.Controllers
{
    public class CategoryController : ApiController
    {
        // GET: api/Category/Names

        [Route("api/Category/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return CategoryService.GetCategoryNames();
        }

        //Get api/Products returning all the products.

        [Route("api/Categories")]
        [HttpGet]
        public List<CategoryModel> GetCategories()
        {
            return CategoryService.GetCategories();
        }

        //Post Add category
        [Route("api/Category/Add")]
        [HttpPost]
        public void AddCategory(CategoryModel c)
        {
            CategoryService.AddCategory(c);
        }
    }
}
