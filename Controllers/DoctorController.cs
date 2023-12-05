using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dashbord.Data;
using dashbord.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dashbord.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public DoctorController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //var doctorList = _dbContext.clinicTable.ToList();
            return View();
        }

        public IActionResult DoneCreatD()
        {
            return View();
        }

        public IActionResult DoneEditD()
        {
            return View();
        }

        public IActionResult DoneDeletD()
        {
            return View();
        }

        public IActionResult Creat()
        {
            return View();
        }
    }
}

