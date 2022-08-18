using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context conn = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = conn.Set<T>();
        }
        public void Delete(T p)
        {
            var deletedEntity = conn.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(p);
            conn.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var addedEntity = conn.Entry(p);
            addedEntity.State = EntityState.Added;
            //_object.Add(p);
            conn.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updatedEntity = conn.Entry(p);
            updatedEntity.State = EntityState.Modified;
            conn.SaveChanges();
        }
    }
}
