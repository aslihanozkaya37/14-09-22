using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KitaplikUygulama.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {
        //T - Şuan Category için genel komutu yazıyoruz.

        //Listeleme metodu
        IEnumerable<T> GetAll(string? includeProperties = null);

        //Ekleme metodu
        void Add(T entity);

        // Filtreleme //ilgili idyi getiriyor bununla beraber bazı özellikleride isteğe balı getiebilsin diye virgülde sonra yazıyoruz. Biz bir şey eklemezsek null saysın ekledikçe eşitlik bozulacak
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties=null);

        // Silme Komutu
        void Remove(T entity);

        //Çoklu silme
        void RemoveRange(IEnumerable<T> entity);
    }
}
