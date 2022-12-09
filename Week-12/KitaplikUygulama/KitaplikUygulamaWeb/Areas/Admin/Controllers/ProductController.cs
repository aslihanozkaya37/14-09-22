using KitaplikUygulama.DataAccess;
using KitaplikUygulama.DataAccess.Repository.IRepository;
using KitaplikUygulama.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KitaplikUygulamaWeb.Areas.Admin.Controllers
{
    

    public class ProductController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _unitOfWork.Category.GetAll();
            return View(objCategoryList);
        }



        //EDİT GET
        [HttpGet]
        public IActionResult Upsert(int id)
        {
            Product product = new Product();
            IEnumerable<SelectListItem>CategoryList = _unitOfWork.Category.GetAll().
                Select( u=>new SelectListItem { Text = u.Name, Value = u.Id.ToString() });
           
            IEnumerable<SelectListItem> CoverTypeList = _unitOfWork.CoverType.GetAll().
               Select(u => new SelectListItem { Text = u.Name, Value = u.Id.ToString() });

            if (id == null || id == 0)
            {
                //create product
                ViewBag.CategoryList = CategoryList;
                ViewData["CoverTypeList"] = CoverTypeList;
                return View(product);
            }
            if (id == null || id == 0)
            {
                //create product
                return View(product);
            }
            else
            {
                //update product
            }



            return View(product);
        }

        //EDİT POST
        [HttpPost]
        public IActionResult Upsert(Category obj)
        {
            if (obj.Name == obj.Id.ToString())
            {
                ModelState.AddModelError("CustomError", "Book name cant be equal to Display Order");
            }


            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category updated succesfully! :) ";
                return RedirectToAction("Index", "Category");
            }
            return View(obj);
        }



        // DELETE GET
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var categoryFromDb = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }


            return View(categoryFromDb);
        }

        //DELETE POST
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int id)
        {
            var obj = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Category.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted succesfully! :) ";
            return RedirectToAction("Index", "Category");


        }



        //CREATE POST
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("CustomError", "Category name cant be equal to Display Order");
            }


            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category created succesfully! :) ";
                return RedirectToAction("Index", "Category");
            }
            return View(obj);
        }
    }
}
