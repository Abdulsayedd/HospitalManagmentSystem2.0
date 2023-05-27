using HospitalManagmentSystem2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagmentSystem2._0.Controllers
{
    [Authorize]
    public class NurseController : Controller
    {
        AccountEntities AccountConnection = new AccountEntities();
        AppointmentEntities AppointmentConnection = new AppointmentEntities();
        NurseAppointmentEntities NurseAppointmentConnection = new NurseAppointmentEntities();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListNurseAppointment()
        {
            string userId = Session["UserId"]?.ToString();

            var nurseAppointments = NurseAppointmentConnection.NurseAppointments.Where(a => a.NurseId.ToString() == userId).ToList();

            return View(nurseAppointments);
        }
        [HttpGet]
        public ActionResult DetailsAppointmentNurse(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsAppointmentNurse(Appointment Sc)
        {
            return View();
        }
    }
}