using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccessLayer.Abstract
{
    public interface IGenericDal<T>where T : class
    {
        Task Insert(T t);
        Task Update(T t);
        Task Delete(T t);

        Task<T> GetBYId(int id);

        Task<List<T>> GetList();
    }
}
