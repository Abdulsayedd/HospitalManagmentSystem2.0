using HospitalManagmentSystem2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagmentSystem2._0.Controllers
{
    [Authorize]
    public class ReciptionistController : Controller
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
        public ActionResult ListAppointmentReceptionist()
        {
            var appointments = AppointmentConnection.Appointments.Where(a=>a.state == 0).ToList();
            return View(appointments);
        }
        public ActionResult AcceptAppointmentReceptionist(int Id)
        {

            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            entry.state = 1;
            AppointmentConnection.SaveChanges();

            return RedirectToAction("ListAppointmentReciptionist");

        }

        public ActionResult DeleteAppointmentReceptionist(int Id)
        {
            Appointment a = AppointmentConnection.Appointments.Find(Id);
            AppointmentConnection.Appointments.Remove(a);
            AppointmentConnection.SaveChanges();
            return RedirectToAction("ListAppointmentReciptionist");
        }

        [HttpGet]
        public ActionResult DetailsAppointmentReceptionist(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsAppointmentReceptionist(Appointment Sc)
        {
            return View();
        }
        public ActionResult ListPaymentReceptionist()
        {
            var payments = PaymentConnection.Payments.Where(a => a.Paid == 1).ToList();
            return View(payments);
        }
        #endregion


    }
}