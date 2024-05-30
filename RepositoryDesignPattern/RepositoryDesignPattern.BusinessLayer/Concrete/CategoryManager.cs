using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task TDelete(Category t)
        {
            await _categoryDal.Delete(t);
        }

        public async Task<Category> TGetById(int id)
        {
           return await _categoryDal.GetBYId(id);
        }

        public async Task<List<Category>> TGetList()
        {
           return await _categoryDal.GetList();
        }

        public async Task TInsert(Category t)
        {
            await _categoryDal.Insert(t);
        }

        public async Task TUpdate(Category t)
        {
            await _categoryDal.Update(t);
        }
    }
}
