

using Microsoft.EntityFrameworkCore;

namespace MagazynEdu.DataAcces
{
    public class Repository<T> : IRepository<T> where T : Entities.EntityBase
    {
        private readonly OfficeStorageContext context;
        private DbSet<T> entities;
        public Repository(OfficeStorageContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public T GetById(int id)
        {
            return entities.SingleOrDefault(e => e.Id == id);
        }
        public void Insert(T entity)
        {
            TrowArgumentExep(entity);
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            TrowArgumentExep(entity);
            entities.Update(entity);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                entities.Remove(entity);
                context.SaveChanges();
            }
        }
        void TrowArgumentExep(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }
    }
}
