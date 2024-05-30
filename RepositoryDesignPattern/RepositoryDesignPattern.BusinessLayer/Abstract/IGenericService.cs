using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task TInsert(T t);
        Task TUpdate(T t);
        Task TDelete(T t);

        Task<T> TGetById(int id);

        Task<List<T>> TGetList();
    }
}
