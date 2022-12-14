using KitaplikUygulama.DataAccess;
using KitaplikUygulama.DataAccess.Repository.IRepository;
using KitaplikUygulama.Models;
using KitaplikUygulama.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KitaplikUygulamaWeb.Areas.Admin.Controllers
{
    

    public class ProductController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
           return View();
        }

       

        //EDİT GET
        [HttpGet]
        public IActionResult Upsert(int id)
        {

            ProductVM productVM = new()
            {
                Product = new(),
                CategoryList = _unitOfWork.Category.GetAll().Select(
                u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(
                u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),

            };


            if (id == null || id == 0)
            {
                //create product
                //ViewBag.CategoryList = CategoryList;
                //ViewBag.CoverTypeList = CoverTypeList;
                //ViewData["CoverTypeList"] = CoverTypeList;
                return View(productVM);
            }
            else
            {
                productVM.Product = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
                //update product

            }

            return View(productVM);
        }

        //EDİT POST
        [HttpPost]
        public IActionResult Upsert(ProductVM obj, IFormFile? file)
        {
          
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                if(file != null)
                {

                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(wwwRootPath, @"images\products");
                    var extension = Path.GetExtension(file.FileName);
                    if(obj.Product.ImageURL!=null)
                    {
                        var oldImagePath = Path.Combine(wwwRootPath, obj.Product.ImageURL.TrimStart('\\'));
                        if(System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);    
                        }
                    }

                    using ( var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        file.CopyTo(fileStreams);
                    }
                    obj.Product.ImageURL = @"images\products\" + fileName + extension;

                }
                if(obj.Product.Id==0)
                {
                    _unitOfWork.Product.Add(obj.Product);
                }
                else
                {
                    _unitOfWork.Product.Update(obj.Product);
                }
                //_unitOfWork.CoverType.Update(obj);
                
                _unitOfWork.Save();
                TempData["success"] = "CoverType updated succesfully! :) ";
                return RedirectToAction("Index", "Product");
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

            var CoverTypeFromDbFirst = _unitOfWork.CoverType.GetFirstOrDefault(u => u.Id == id);

            if (CoverTypeFromDbFirst == null)
            {
                return NotFound();
            }


            return View(CoverTypeFromDbFirst);
        }

        //DELETE POST
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int id)
        {
            var obj = _unitOfWork.CoverType.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.CoverType.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "CoverType deleted succesfully! :) ";
            return RedirectToAction("Index", "CoverType");


        }

        #region API CALL
        [HttpGet]
        public IActionResult GetAll()
        {
            var productlist = _unitOfWork.Product.GetAll(includeProperties:"Category,CoverType");
            return Json(new { data = productlist });
        }

        #endregion


    }



}
