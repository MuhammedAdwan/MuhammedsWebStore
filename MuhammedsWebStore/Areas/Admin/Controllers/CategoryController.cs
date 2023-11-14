using MuhammedsBooks.DataAccess.Repository.IRepository;
using MuhammedsBooks.Models;
using Microsoft.AspNetCore.Mvc;


namespace MuhammedsWebStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                {
                    _unitOfWork.Category.Add(category);
                  //  _unitOfWork.save();
                }
                else
                {

                    _unitOfWork.Category.update(category);

                }
            }
            return View(category);
        }







        public IActionResult Upsert(int? id) //action method for upsert
        {
            Category category = new Category();//using NiharBooks.Models;
            if (id == null)
            {
                // this is to creatte
                return View(category);
            }

            //this for the edit
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View();
        }






            //API calls here
            #region API CALLS
            [HttpGet]
        public IActionResult GetAll()
        {
            //Return NotFound()
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }

}
