using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Exmination.Data.EnrollRepositry;
using Exmination.Data.RegisterRepositry;
using Exmination.Models;
using Exmination.Models.Account;
using Exmination.Models.Student;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exmination.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IRegisterRepositry _repositry;
        private readonly IEnrollRepositry enrollRepositry;

        public AccountController(IHostingEnvironment hostingEnvironment, IRegisterRepositry repositry,IEnrollRepositry enrollRepositry)
        {
            this.hostingEnvironment = hostingEnvironment;
            _repositry = repositry;
            this.enrollRepositry = enrollRepositry;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            
            if (ModelState.IsValid)
            {

                if(_repositry.Login(model.Username , model.Password))
                {
                    HttpContext.Session.SetString("UserName", model.Username);

                    Enrollment enrollment = enrollRepositry.GetEnrollmentById(model.Username);
                    if(enrollment == null)
                        return RedirectToAction("Enroll", "Student");
                    return RedirectToAction("Enrolled","Student",enrollment);
                }
                TempData["Invalid"] = "Inavalid Creadintatial !";
                
            }
            
            return View(new LoginModel() { Username="",Password=""});
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Registration(RegistrationViewModel model)
        {

            if(ModelState.IsValid)
            {
                string password = model.CandidateName.Substring(0, 4).ToUpper() + model.Mobile.Substring(0, 4);
              
                Console.WriteLine(password);
                Registation registation = new Registation()
                {
                    CandidateName = model.CandidateName,
                    Email = model.Email,
                    Mobile = model.Mobile,
                    ExaminationApplied = model.ExaminationApplied,
                    Password = password
                };

                bool status = _repositry.Add(registation);
                if (status)
                {
                    Registation reg = _repositry.GetRegistationById(model.Email);
                    TempData.Add("Reg",reg.Registration_number);
                    TempData.Add("Password",reg.Password);
                    return RedirectToAction("Index","Home");
                }
            }
            return View(new RegistrationViewModel());
        }

        public IEnumerable<Registation> GetRegistration()
        {
            return _repositry.GetRegistation();
        }
        //[HttpPost]
        //public IActionResult Registration(Photo model)
        //{
        //    //string uniqueFileName = null;
        //    //string path = model.PhotoPath.FileName;

        //    //double ImageInKB = model.PhotoPath.Length / 1024; 

        //    //string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
        //    //uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PhotoPath.FileName;
        //    //string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        //    //model.PhotoPath.CopyTo(new FileStream(filePath, FileMode.Create));
        //    return View();
        //}
    }
}
