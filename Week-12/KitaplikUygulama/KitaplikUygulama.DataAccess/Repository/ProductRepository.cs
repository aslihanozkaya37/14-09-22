using KitaplikUygulama.DataAccess.Repository.IRepository;
using KitaplikUygulama.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaplikUygulama.DataAccess.Repository
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {

        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        //public void Save()
        //{
        //    _db.SaveChanges();
        //}
        public void Update(Product obj)
        {
            var objFromDB=_db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if(objFromDB!=null)
            {
                objFromDB.Title = obj.Title;
                objFromDB.ISBN = obj.ISBN;
                objFromDB.Description = obj.Description;
                objFromDB.Price = obj.Price;
                objFromDB.Price50 = obj.Price50;
                objFromDB.Price100 = obj.Price100;
                objFromDB.ListPrice = obj.ListPrice;
                objFromDB.CategoryId = obj.CategoryId;
                objFromDB.Author = obj.Author;
                objFromDB.CoverTypeId = obj.CoverTypeId;
                if(obj.ImageURL!=null)
                {
                  objFromDB.ImageURL=obj.ImageURL;
                }




            }
        }
    }
}
