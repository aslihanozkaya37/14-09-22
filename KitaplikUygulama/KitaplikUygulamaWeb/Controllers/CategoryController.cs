using KitaplikUygulamaWeb.Data;
using KitaplikUygulamaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KitaplikUygulamaWeb.Controllers
{
    
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList =
            _db.Categories;
            return View(objCategoryList);
        }

        
        //get//veritabanımızdaki verilerimizi görüntülememizi sağlar
        public IActionResult Create()
        {
           
            return View();
        }


        [HttpGet]//edit ekranını görüntüleme
        public IActionResult Edit(int id)
        {
            if(id==null|| id==0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Categories.Find(id);
            if(categoryFromDb==null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }



        //post
        [HttpPost]//Güncellediğimiz verileri veritabanına tekrar göndermemizi sağlar.
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "Category name cant be equal to Display Order ");
            }


            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }



        [HttpPost]
        //Bu veritabanımıza veri eklememizi sağlıyor.
        public IActionResult Create(Category obj)
        {   if(obj.Name==obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "Category name cant be equal to Display Order ");
            }
            
            
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }


        [HttpGet]//delete ekranını görüntüleme
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Categories.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }


        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            var obj = _db.Categories.Find(id);

            if (obj==null)
            {
                return NotFound();
            }

            _db.Categories.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index","Category");

            
        }

     


    }
}
