using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo
    {
        static IMSEntities context;
        static CategoryRepo()
        {
            context = new IMSEntities();
        }
        public static List<string> GetCategoryNames()
        {
            var data = context.Categories.Select(x => x.Name).ToList();
            return data;
        }
        public static List<Category> GetCategories()
        {
            var data = context.Categories.ToList();
            return data;
        }

        public static void AddCategory(Category c)
        {
            context.Categories.Add(c);
            context.SaveChanges();
        }
    }
}
