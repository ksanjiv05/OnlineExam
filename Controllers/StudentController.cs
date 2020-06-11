using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Exmination.Data;
using Exmination.Data.AdmitCardRepositry;
using Exmination.Data.CenterRepositry;
using Exmination.Data.EnrollRepositry;
using Exmination.Data.RegisterRepositry;
using Exmination.Models;
using Exmination.Models.Account;
using Exmination.Models.Student;
using Exmination.ModelView.Services;
using Exmination.ModelView.Student;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace Exmination.Controllers
{
    public class StudentController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IEnrollRepositry repositry;
        private readonly ICernterRepositry cernterRepositry;
        private readonly IRegisterRepositry registerRepositry;
        private readonly IAdmitCardRepositry cardRepositry;

        public StudentController(IHostingEnvironment hostingEnvironment,
            IEnrollRepositry repositry,
            ICernterRepositry cernterRepositry,
            IRegisterRepositry registerRepositry,
            IAdmitCardRepositry cardRepositry
            )
        {
            this.hostingEnvironment = hostingEnvironment;
            this.repositry = repositry;
            this.cernterRepositry = cernterRepositry;
            this.registerRepositry = registerRepositry;
            this.cardRepositry = cardRepositry;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Enroll()
        {
            //CenterData centerData = new CenterData();
            //EnrollmentViewModel enrollment = new EnrollmentViewModel();
            //enrollment.ExameCenterCh1 = centerData.Center();
            //enrollment.ExameCenterCh2 = centerData.Center();
            //enrollment.ExameCenterCh3 = centerData.Center();

            if (HttpContext.Session.GetString("UserName") == null)
                return RedirectToAction("Login","Account");

            Registation registation = registerRepositry.GetRegistationByRegistration_num(HttpContext.Session.GetString("UserName"));
            EnrollmentViewModel enrollment = new EnrollmentViewModel();
            enrollment.Name = registation.CandidateName;
            enrollment.ContactNumber = registation.Mobile;
            enrollment.Email = registation.Email;
            enrollment.Programm = registation.ExaminationApplied;
            enrollment.ExameCenterCh1 = cernterRepositry.GetExamCentersSeatAvaiablity();
            return View(enrollment);
        }
        [HttpPost]
        public IActionResult Enroll(EnrollmentViewModel model)
        {
            string registration_num = HttpContext.Session.GetString("UserName");
            if (registration_num == null)
            {
                TempData["EnrollSession"] = "Session Expired !";
                return RedirectToAction("Login", "Account");
            }
            if (ModelState.IsValid)
            {
                //string path = model.Profile.FileName;
                //string path2 = model.Signature.FileName;

                double ImageInKB = model.Profile.Length / 1024;

                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                string uniqueProfile = Guid.NewGuid().ToString() + "_" + model.Profile.FileName;
                string profilePath = Path.Combine(uploadsFolder, uniqueProfile);

                string uniqueSignature = Guid.NewGuid().ToString() + "_" + model.Signature.FileName;
                string signaturePath = Path.Combine(uploadsFolder, uniqueSignature);

                Registation registation = registerRepositry.GetRegistationByRegistration_num(HttpContext.Session.GetString("UserName"));
                Enrollment enrollment = new Enrollment()
                {

                    Name = registation.CandidateName,
                    Registration_number= registration_num,
                    DOB = model.DOB,
                    Sex = model.Sex,
                    Catagory= model.Catagory,
                    ContactNumber = registation.Mobile,
                    Email = registation.Email,
                    Father = model.Father,
                    Mobile = model.Mobile,
                    ParmanentAddress = model.ParmanentAddress,
                    SameAsParmanent = model.SameAsParmanent,
                    CorrespondanceAddress = model.CorrespondanceAddress,
                    Programm = registation.ExaminationApplied,
                    ExameCenter = model.centerCode,
                    Profile = uniqueProfile,
                    Signature = uniqueSignature
                };

                if (repositry.Add(enrollment))
                {
                    model.Profile.CopyTo(new FileStream(profilePath, FileMode.Create));
                    model.Profile.CopyTo(new FileStream(signaturePath, FileMode.Create));
                    TempData["Enroll"] = "Your are Enrolled !";
                }
                return RedirectToAction("Index","Home");
            }
            else
            {
                EnrollmentViewModel enrollment = new EnrollmentViewModel();
                enrollment.ExameCenterCh1 = cernterRepositry.GetExamCenters();
                return View(enrollment);
            }
           

            
        }

        public IActionResult Admit_Card()
        {
            return View();
            //return new ViewAsPdf();
        }
        [HttpPost]
        public IActionResult Admit_Card(AdmitCard model)
        {
            if(ModelState.IsValid)
            {
                StudentAdmitCardViewModel studentAdmitCard = cardRepositry.GetAdmitCard(model.RollNumber, model.ExamFor);
                if(studentAdmitCard==null)
                {
                    TempData["admitCardRes"] = "Bad creadential !!!";
                    return RedirectToAction("Admit_Card", "Student");
                }
                return RedirectToAction("PrintAdmitCard", "Student",studentAdmitCard);
            }
            return View();
        }

        public IActionResult PrintAdmitCard(StudentAdmitCardViewModel model)
        {
            return new   ViewAsPdf(model);
            //return View();
        } 
        [HttpGet]
        public IActionResult Enrolled(Enrollment model)
        {
            return View(model);
        }
    }
}