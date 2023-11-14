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
