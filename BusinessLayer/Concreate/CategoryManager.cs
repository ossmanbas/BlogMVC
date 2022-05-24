﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        ICategoryDAL _categoryDAL;
      

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void AddCategory(Category category)
        {
             _categoryDAL.Insert(category);
        }

        public Category GetCategoryById(int id)
        {
           return _categoryDAL.GetByID(id);
        }

        public List<Category> GetList()
        {
           return _categoryDAL.GetAll();
        }

        public void RemoveCategory(Category category)
        {
           _categoryDAL.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
          _categoryDAL.Update(category);
        }
    }
}
