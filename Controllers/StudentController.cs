using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Exmination.Data;
using Exmination.Data.EnrollRepositry;
using Exmination.Models.Student;
using Exmination.ModelView.Student;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace Exmination.Controllers
{
    public class StudentController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IEnrollRepositry repositry;

        public StudentController(IHostingEnvironment hostingEnvironment,IEnrollRepositry repositry)
        {
            this.hostingEnvironment = hostingEnvironment;
            this.repositry = repositry;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Enroll()
        {
            CenterData centerData = new CenterData();
            EnrollmentViewModel enrollment = new EnrollmentViewModel();
            enrollment.ExameCenterCh1 = centerData.Center();
            enrollment.ExameCenterCh2 = centerData.Center();
            enrollment.ExameCenterCh3 = centerData.Center();
            return View(enrollment);
        }
        [HttpPost]
        public IActionResult Enroll(EnrollmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                //string path = model.Profile.FileName;
                //string path2 = model.Signature.FileName;

                double ImageInKB = model.Profile.Length / 1024;

                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Profile.FileName;
                string profilePath = Path.Combine(uploadsFolder, uniqueFileName);

                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Signature.FileName;
                string signaturePath = Path.Combine(uploadsFolder, uniqueFileName);

                Enrollment enrollment = new Enrollment()
                {

                    Name = model.Name,
                    DOB = model.DOB,
                    ContactNumber = model.ContactNumber,
                    Email = model.Email,
                    Father = model.Father,
                    Mobile = model.Mobile,
                    ParmanentAddress = model.ParmanentAddress,
                    SameAsParmanent = model.SameAsParmanent,
                    CorrespondanceAddress = model.CorrespondanceAddress,
                    Programm = model.Programm,
                    ExameCenterCh1 = null,

                    Profile = profilePath,
                    Signature = signaturePath
                };

                if (repositry.Add(enrollment))
                {
                    model.Profile.CopyTo(new FileStream(profilePath, FileMode.Create));
                    model.Profile.CopyTo(new FileStream(signaturePath, FileMode.Create));
                }
                return RedirectToAction("Index","Home");
            }
            else
            {
                CenterData centerData = new CenterData();
                EnrollmentViewModel enrollment = new EnrollmentViewModel();
                enrollment.ExameCenterCh1 = centerData.Center();
                enrollment.ExameCenterCh2 = centerData.Center();
                enrollment.ExameCenterCh3 = centerData.Center();
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
            return RedirectToAction("PrintAdmitCard", "Student");
        }

        public IActionResult PrintAdmitCard()
        {
            return new   ViewAsPdf();
            //return View();
        }

    }
}