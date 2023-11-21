using MuhammedsBooks.DataAccess.Repository.IRepository;
using MuhammedsBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MuhammedsWebStore.DataAccess.Data;
using MuhammedsBooks.DataAccess.Repository;
using Microsoft.AspNetCore.Hosting;

namespace MuhammedsWebStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Product product = new Product();
            if (id == null)
            {
                return View(product);
            }

            product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }





        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.Id == 0)
                {
                    _unitOfWork.Product.Add(product);
                    _unitOfWork.Save();
                }
                else
                {

                    _unitOfWork.Product.Update(product);

                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));  //to see all the Product
            }
            return View(product);
        }



        //API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Product.GetAll(includeProperties: "Category,CoverType");
            return Json(new { data = allObj });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.GetById(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Product.Remove(id);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}