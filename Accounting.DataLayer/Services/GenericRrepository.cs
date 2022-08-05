using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private Accounting_DBEntities _db;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(Accounting_DBEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }
        
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity , bool >> where = null)
        {
            IQueryable<TEntity> query = _dbSet ;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }

        public virtual TEntity GetByID(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual bool Update(Accounting entity)
        {
            var local = _db.Set<Accounting>()
                     .Local
                     .FirstOrDefault(f => f.ID == entity.ID );
            if (local != null)
            {
                _db.Entry(local).State = EntityState.Detached;
            }
            _db.Entry(entity).State = EntityState.Modified;
            return true;
        }
        public virtual bool Update(Login entity)
        {
            var local = _db.Set<Login>()
                     .Local
                     .FirstOrDefault(f => f.LoginID == entity.LoginID);
            if (local != null)
            {
                _db.Entry(local).State = EntityState.Detached;
            }
            _db.Entry(entity).State = EntityState.Modified;
            return true;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public virtual void Delete(object id)
        {
            var entity = GetByID(id);
            Delete(entity);

        }


    }
}

