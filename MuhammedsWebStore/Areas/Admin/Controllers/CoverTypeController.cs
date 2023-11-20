using MuhammedsBooks.DataAccess.Repository.IRepository;
using MuhammedsBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MuhammedsBooks.DataAccess.Repository;

namespace MuhammedsWebStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            CoverType coverType = new CoverType();
            if (id == null)
            {
                return View(coverType);
            }

            coverType = _unitOfWork.CoverType.Get(id.GetValueOrDefault());
            if (coverType == null)
            {
                return NotFound();
            }
            return View(coverType);
        }





        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CoverType coverType)
        {
            if (ModelState.IsValid)
            {
                if (coverType.Id == 0)
                {
                    _unitOfWork.CoverType.Add(coverType);
                    _unitOfWork.save();
                }
                else
                {

                    _unitOfWork.CoverType.Update(coverType);

                }
                _unitOfWork.save();
                return RedirectToAction(nameof(Index));  //to see all the coverType
            }
            return View(coverType);
        }



        //API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //Return NotFound()
            var allObj = _unitOfWork.CoverType.GetAll();
            return Json(new { data = allObj });
        }
        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.CoverType.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = true, message = "Error While deleting" });

            }

            _unitOfWork.CoverType.Remove(objFromDb);
            _unitOfWork.save();
            return Json(new { success = true, message = "Delete successful" });
        }

        #endregion
    }

}
