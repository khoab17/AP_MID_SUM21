using BLL.Services.MapperConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;

namespace BLL
{
    public class CategoryService
    {
        static CategoryService()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSettings>());
        }
        public static List<string> GetCategoryNames()
        {
            return CategoryRepo.GetCategoryNames();
        }
        public static List<CategoryModel> GetCategories()
        {
            var temp = CategoryRepo.GetCategories();
            var data = AutoMapper.Mapper.Map<List<Category>, List<CategoryModel>>(temp);
            return data;
        }
        public static void AddCategory(CategoryModel c)
        {
            var data = AutoMapper.Mapper.Map<CategoryModel, Category>(c);
            CategoryRepo.AddCategory(data);
        }
    }
}
