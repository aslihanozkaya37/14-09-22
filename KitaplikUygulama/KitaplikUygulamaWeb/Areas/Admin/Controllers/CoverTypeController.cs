using KitaplikUygulama.DataAccess;
using KitaplikUygulama.DataAccess.Repository.IRepository;
using KitaplikUygulama.Models;
using Microsoft.AspNetCore.Mvc;

namespace KitaplikUygulamaWeb.Areas.Admin.Controllers
{
    

    public class CoverTypeController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<CoverType> objCoverTypeList = _unitOfWork.CoverType.GetAll();
            return View(objCoverTypeList);
        }

        // CREATE GET
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        //CREATE POST
        [HttpPost]
        public IActionResult Create(CoverType obj)
        {
            
            if (ModelState.IsValid)
            {
                _unitOfWork.CoverType.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "CoverType created succesfully! :) ";
                return RedirectToAction("Index", "CoverType");
            }
            return View(obj);
        }

        //EDİT GET
        [HttpGet]
        public IActionResult Edit(int id)
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

        //EDİT POST
        [HttpPost]
        public IActionResult Edit(CoverType obj)
        {
          
            if (ModelState.IsValid)
            {
                _unitOfWork.CoverType.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "CoverType updated succesfully! :) ";
                return RedirectToAction("Index", "CoverType");
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



       
    }
}
