using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CategoryManager : ICategoryService
    {
        EFCategoryRepository efCatRepo;

        public CategoryManager()
        {
            efCatRepo = new EFCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            efCatRepo.Insert(category);
        }

        public Category GetCategoryById(int id)
        {
           return efCatRepo.GetByID(id);
        }

        public List<Category> GetList()
        {
           return efCatRepo.GetAll();
        }

        public void RemoveCategory(Category category)
        {
            efCatRepo.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
           efCatRepo.Update(category);
        }
    }
}
