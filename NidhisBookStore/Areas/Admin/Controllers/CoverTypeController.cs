using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NidhisBooks.DataAccess.Repository.IRepository;
using NidhisBooks.Models;

namespace NidhisBookStore.Areas.Admin.Controllers
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
            CoverType covertype = new CoverType();
            if (id == null)
            {
                return View(covertype);
            }
            covertype = _unitOfWork.CoverType.Get(id.GetValueOrDefault());
            if (covertype == null)
            {
                return NotFound();
            }
            return View(covertype);
        }


        // use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CoverType covertype)
        {
            if (ModelState.IsValid) //checks all validations in the model (e.g. Name required) to increase security
            {
                if (covertype.Id == 0)
                {
                    _unitOfWork.CoverType.Add(covertype);

                }
                else
                {
                    _unitOfWork.CoverType.Update(covertype);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(covertype);
        }

        //API calls here

        #region API CALLS
        [HttpGet]
            public IActionResult GetAll()
            {
                // return NotFound();
                var allObj = _unitOfWork.CoverType.GetAll();
                return Json(new { data = allObj });
            }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.CoverType.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.CoverType.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}
