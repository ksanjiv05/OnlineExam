using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exmination.Data.AdmitCardRepositry;
using Exmination.Data.CenterRepositry;
using Exmination.Data.RegisterRepositry;
using Exmination.Models;
using Exmination.Models.Account;
using Exmination.Models.Services;
using Exmination.ModelView.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exmination.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRegisterRepositry repositry;
        private readonly ICernterRepositry cernterRepositry;
        private readonly IAdmitCardRepositry admitCardRepositry;

        public AdminController(IRegisterRepositry repositry, ICernterRepositry cernterRepositry, IAdmitCardRepositry admitCardRepositry)
        {
            this.repositry = repositry;
            this.cernterRepositry = cernterRepositry;
            this.admitCardRepositry = admitCardRepositry;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string x)
        {
            return View();
        }

        public ActionResult<IEnumerable<Registation>> Dashboard()
        {
            IEnumerable<Registation> registations = repositry.GetRegistation();

            return View(registations);
        }
        
        public IActionResult EnrollApprove()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddCenter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCenter(EximinationCenter model)
        {
            model.SeatAvailable = model.TotalSeat;
            if(ModelState.IsValid)
            {
                cernterRepositry.Add(model);
            }
            return View();
        }
        [HttpGet]
        public IActionResult GenrateAdmitCard()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GenrateAdmitCard(GenrateAdmitCard model)
        {
            if(ModelState.IsValid)
            {
                StudentAdmitCard admitCard = new StudentAdmitCard()
                {
                    ExameDate = model.ExameDate,
                    reportingTime = model.reportingTime,
                    EntryClosingTime = model.EntryClosingTime,
                    GenrateExameFor = model.GenrateExameFor
                };

                if(admitCardRepositry.Add(admitCard))
                {
                    TempData["Responce"] = "Admit Card Genrated !!!";
                }
                else
                {
                    TempData["Responce"] = "May Admit Card allready genrated !!!";
                }
            }
            return View();
        }
    }
}