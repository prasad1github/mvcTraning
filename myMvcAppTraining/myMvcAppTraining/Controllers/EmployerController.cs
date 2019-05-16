using myMvcAppTraining.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myMvcAppTraining.Controllers
{
    public class EmployerController : Controller
    {

        public ActionResult EmpList()
        {
            DBCon db = new DBCon();
            List<Employer> employers = db.employer.OrderBy(e => e.empFirstname).ToList();

            return View(employers);
        }

        public ActionResult EmpDetails(int empId)
        {
            DBCon db = new DBCon();
            Employer employer = new Employer();
            employer = db.employer.Single(m => m.empId == empId);
        
            return View(employer);
        }


        public ActionResult EmpCreate()
        {
            DBCon db = new DBCon();
            #region
            //EmployerDetails employerDetails = new EmployerDetails();
            //employerDetails.emp = db.employer.Single(m => m.empId == empId);
            //IEnumerable<SelectListItem> comList = db.company.Select(x => new SelectListItem()
            //{
            //    Value = x.companyId.ToString(),
            //    Text = x.name
            //});
            //employerDetails.companyList = comList;
            #endregion

            ViewBag.companyList = new SelectList(db.company, "companyId", "name");
            return PartialView("EmpCreatePartialView", new Employer());
        }

        [HttpPost]
        public ActionResult EmpCreate(Employer employer)
        {
            DBCon db = new DBCon();
          

            if (ModelState.IsValid)
            {
                #region add
                // Employer eFind = db.employer.Where(x => x.empUsername == employer.empUsername).First();
                //db.Entry(employer).State = EntityState.Added;
                //db.SaveChanges();
                #endregion add
                db.employer.Add(employer);
                db.SaveChanges();
                return RedirectToAction("EmpList");
            }
            #region
            //DBCon db = new DBCon();
            //EmployerDetails employerDetails = new EmployerDetails();
            //employerDetails.emp = db.employer.Single(m => m.empId == empId);
            //IEnumerable<SelectListItem> comList = db.company.Select(x => new SelectListItem()
            //{
            //    Value = x.companyId.ToString(),
            //    Text = x.name
            //});
            //employerDetails.companyList = comList;
            #endregion
            ViewBag.companyList = new SelectList(db.company, "companyId", "name");
            return new EmptyResult();
        }


        public ActionResult EmpEdit(int empId)
        {
            DBCon db = new DBCon();
            EmployerDetails employerDetails = new EmployerDetails();
            employerDetails.emp = db.employer.Single(m => m.empId == empId);
            IEnumerable<SelectListItem> comList = db.company.Select(x => new SelectListItem()
            {
                Value = x.companyId.ToString(),
                Text = x.name
            });
            employerDetails.companyList = comList;
            return PartialView("EmpEditPartialView", employerDetails);
            #region EmpEdit2
            //Employer emp= db.employer.Single(m => m.empId == empId);
            //ViewBag.ddl = new SelectList(db.company, "companyId", "name");
            //return PartialView("EditPartial", emp);
            #endregion

        }


        [HttpPost]
        public ActionResult EmpEdit(Employer emp)
        {
            DBCon db = new DBCon();
            //Employer emp = db.employer.Find(emp.empId);
            if (ModelState.IsValid)
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("EmpList");
            }
            return RedirectToAction("EmpEdit", emp.empId);
        }

        [HttpGet]
        public ActionResult EmpDelete(int empId)
        {
            DBCon db = new DBCon();
            //Employer empToDelete= db.employer.Single(x=> x.empId==empId);
            Employer empToDelete = db.employer.Find(empId);
            if (ModelState.IsValid)
            {
                db.employer.Remove(empToDelete);
                db.SaveChanges();
                return RedirectToAction("EmpList");
            }
            return View();
        }
    }
}
