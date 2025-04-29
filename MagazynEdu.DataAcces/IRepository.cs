

using MagazynEdu.DataAcces.Entities;

namespace MagazynEdu.DataAcces
{
    public interface IRepository<T> where T : EntityBase
    {
        
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
   
}
