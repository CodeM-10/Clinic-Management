using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dashbord.Data;
using Microsoft.AspNetCore.Mvc;
using dashbord.Models;
using dashbord.Migrations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dashbord.Controllers
{
    public class ClinicsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ClinicsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: /<controller>/

        public IActionResult DoneCreat()
        {
            return View();
        }

        public IActionResult DoneEdit()
        {
            return View();
        }
        
        public IActionResult DoneDelet()
        {
            return View();
        }
        public IActionResult Index()
        {
            var clinicList = _dbContext.clinicTable.ToList();
            return View(clinicList);
        }
      

        public IActionResult Creat()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Creat(Clinic cln)
        {
            try
            {
                _dbContext.clinicTable.Add(cln);
                _dbContext.SaveChanges();
                 return RedirectToAction(nameof(DoneCreat));

                
            }
            catch
            {
                ModelState.AddModelError("", "You have to fill all the required fields ");
                return View();

            }
            //if (ModelState.IsValid)
            //{
            //    _dbContext.clinicTable.Add(cln);
            //    _dbContext.SaveChanges();
            //}
            //else {
            //    ModelState.AddModelError("", "You have to fill all the required fields ");
            //}
            ////return View();
            //return RedirectToAction(nameof(DoneCreat));



        }

        public IActionResult Edit(int Id)
        {
            var item = _dbContext.clinicTable.Find(Id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(int Id, Clinic cl2)
        {
            try
            {
                //string fileName = UploadFile(cl2.File, viewModel.ImageUrl);

                if (Id != cl2.Id ) { return NotFound(); }
                else
                {
                    _dbContext.clinicTable.Update(cl2);
                    _dbContext.SaveChanges();
                    return RedirectToAction(nameof(DoneEdit));
                }
            }
            catch
            {
                ModelState.AddModelError("", "You have to fill all the required fields ");
                return View();

            }
            //if (Id != cl2.Id)
            //{
            //    return NotFound();
            //}
            //if (ModelState.IsValid)
            //{
            //    _dbContext.Update(cl2);
            //    _dbContext.SaveChanges();
            //}
            ////return View(cl2, );
            //return RedirectToAction(nameof(DoneEdit));



        }

        public IActionResult Delete(int Id)
        {
            var clin_item = _dbContext.clinicTable.Find(Id);
            if (clin_item == null)
            {
                return NotFound();
            }
            return View(clin_item);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int Id, Clinic dclin)
        {
            try
            {
                if (dclin == null) { return NotFound(); }
                else
                {
                    _dbContext.clinicTable.Remove(dclin);
                    _dbContext.SaveChanges();
                    return RedirectToAction(nameof(DoneDelet));
                }
            }
            catch
            {
                return View();

            }
            //if (dclin == null)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    _dbContext.clinicTable.Remove(dclin);
            //    _dbContext.SaveChanges();
            //}
            //return RedirectToAction(nameof(DoneDelet));



        }





    }
}

