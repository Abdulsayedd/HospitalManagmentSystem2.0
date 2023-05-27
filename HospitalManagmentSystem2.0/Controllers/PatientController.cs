using HospitalManagmentSystem2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagmentSystem2._0.Controllers
{
    [Authorize]
    public class PatientController : Controller
    {
        #region base
        AppointmentEntities AppointmentConnection = new AppointmentEntities();
        PaymentEntities PaymentConnection = new PaymentEntities();
        public ActionResult Index()
        {
            return View();
        }
        #endregion


        #region appointment
        public ActionResult ListAppointmentPatient()
        {
                string id = (string)Session["UserId"];
                var appointments = AppointmentConnection.Appointments.Where(a => a.IdPatient == id).ToList();
                return View(appointments);
        }
        [HttpGet]
        public ActionResult CreateAppointmentPatient()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAppointmentPatient(Appointment Sc)
        {
            if (ModelState.IsValid)
            {
                AppointmentConnection.Appointments.Add(Sc);
                AppointmentConnection.SaveChanges();
                return RedirectToAction("ListAppointmentPatient");
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditAppointmentPatient(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult EditAppointmentPatient(Appointment Sc)
        {
            if (ModelState.IsValid)
            {
                AppointmentConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                AppointmentConnection.SaveChanges();
                return RedirectToAction("ListAppointmentPatient");
            }
            return View();
        }
        public ActionResult DeleteAppointmentPatient(int Id)
        {
            Appointment a = AppointmentConnection.Appointments.Find(Id);
            AppointmentConnection.Appointments.Remove(a);
            AppointmentConnection.SaveChanges();
            return RedirectToAction("ListAppointmentPatient");
        }

        [HttpGet]
        public ActionResult DetailsAppointmentPatient(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsAppointmentPatient(Appointment Sc)
        {
            return View();
        }
        #endregion


        #region payment
        [HttpGet]
        public ActionResult CreatePaymentPatient()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatePaymentPatient(Payment Sc)
        {
            if (ModelState.IsValid)
            {
                PaymentConnection.Payments.Add(Sc);
                PaymentConnection.SaveChanges();
                return RedirectToAction("Home","Home");
            }
            return View();
        }
        #endregion


    }
}