using KitaplikUygulama.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KitaplikUygulama.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly ApplicationDbContext _db;
        public DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public void Add(T entity)
        {
           dbSet.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            //IEnumarable ile IQueryable arasındaki farklar şöyledir; IEnumarabla tüm verileri alıp memoryde tutarak sorguları memori üzerinden yapar. IQueryable ise şartlara bağlı olarak query oluştturur ve bu şartlar sonucu olarak veritabnı üzerinden sorgu çeker. Çoklu kayıtlar üzerinden sorgu yapıyorsak IQueryable çok daha hızlı çalışır.  IEnumarable koleksiyon için idealdir. Hafıza dışı koleksiyonlarda(veritabanı, servisler vs.) Queryable daha idealdir.
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            // buradaki where ifadesi filtreden geçen elemanı gösteren ifadedir.
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);   
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}
