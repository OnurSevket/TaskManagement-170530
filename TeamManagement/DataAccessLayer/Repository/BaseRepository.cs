using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        //Protected yapılacak Hoca ayarlamıştı
        TaskManagementContext _context;
        public BaseRepository(TaskManagementContext context)
        {
            _context = context;
        }
        public virtual void Add(TEntity item)
        {
            _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Added;
        }

        public void Remove(TEntity item)
        {
            _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Deleted;
        }

        public void Update(TEntity item)
        {
            _context.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Modified;
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().AsNoTracking().SingleOrDefault(e => e.ID == id);
        }

        public ICollection<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking().ToList();
        }
    }
}
