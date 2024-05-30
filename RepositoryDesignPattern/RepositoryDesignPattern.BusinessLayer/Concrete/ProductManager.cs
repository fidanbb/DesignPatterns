using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Concrete;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Concrete
{


    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task TDelete(Product t)
        {
            await _productDal.Delete(t);
        }

        public async Task<Product> TGetById(int id)
        {
           return await _productDal.GetBYId(id);
        }

        public async Task<List<Product>> TGetList()
        {
            return await _productDal.GetList();
        }

        public async Task TInsert(Product t)
        {
            await _productDal.Insert(t);
        }

        public async Task<List<Product>> TProductListWithCategory()
        {
            return await _productDal.ProductWithCategory();
        }

        public async Task TUpdate(Product t)
        {
            await _productDal.Update(t);
        }
    }
}
