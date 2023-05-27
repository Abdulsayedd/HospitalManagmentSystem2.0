using HospitalManagmentSystem2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagmentSystem2._0.Controllers
{
    public class HomeController : Controller
    {
        #region base
        AccountEntities AccountConnection = new AccountEntities();
        AppointmentEntities AppointmentConnection = new AppointmentEntities();
        PaymentEntities PaymentConnection = new PaymentEntities();
        SalaryEntities SalaryConnection = new SalaryEntities();
        MedicineEntities MedicineConnection = new MedicineEntities();
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Home()
        {
            return View();
        }
        #endregion


        #region appointment
        [Authorize]
        public ActionResult ListAppointment()
        {
            return View(AppointmentConnection.Appointments.ToList());
        }
        [HttpGet]
        [Authorize]
        public ActionResult CreateAppointment()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult CreateAppointment(Appointment Sc)
        {
            if(ModelState.IsValid)
            {
                AppointmentConnection.Appointments.Add(Sc);
                AppointmentConnection.SaveChanges();
                return RedirectToAction("ListAppointment");
            }
            return View();
        }
        [HttpGet]
        [Authorize]
        public ActionResult EditAppointment(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        [Authorize]
        public ActionResult EditAppointment(Appointment Sc)
        {
            if (ModelState.IsValid)
            {
                AppointmentConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                AppointmentConnection.SaveChanges();
                return RedirectToAction("ListAppointment");
            }
            return View();
        }
        [Authorize]
        public ActionResult DeleteAppointment(int Id)
        {
           Appointment a = AppointmentConnection.Appointments.Find(Id);
            AppointmentConnection.Appointments.Remove(a);
            AppointmentConnection.SaveChanges();
            return RedirectToAction("ListAppointment");
        }

        [HttpGet]
        [Authorize]
        public ActionResult DetailsAppointment(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        [Authorize]
        public ActionResult DetailsAppointment(Appointment Sc)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
        #endregion


        #region about and contact
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        #endregion


    }
}