using HospitalManagmentSystem2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagmentSystem2._0.Controllers
{
    [Authorize]
    public class DoctorController : Controller
    {
        #region base
        AccountEntities AccountConnection = new AccountEntities();
        AppointmentEntities AppointmentConnection = new AppointmentEntities();
        SampleAppointmentEntities SampleConnection = new SampleAppointmentEntities();
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region appointment
        public ActionResult AcceptWaitingAppointmentDoctor(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            entry.state = 1;
            AppointmentConnection.SaveChanges();
            return RedirectToAction("ListWaitingAppointmentDoctor");
        }
        public ActionResult ListAllAppointmentDoctor()
        {
            string id = (string)Session["UserId"];
            var appointments = AppointmentConnection.Appointments.Where(a => a.IdDoctor == id).ToList();
            return View(appointments);
        }
        public ActionResult ListWaitingAppointmentDoctor()
        {
            string id = (string)Session["UserId"];
            var appointments = AppointmentConnection.Appointments.Where(a => a.IdDoctor == id && a.state==0).ToList();
            return View(appointments);
        }
        public ActionResult ListCurrentAppointmentDoctor()
        {
            string id = (string)Session["UserId"];
            var appointments = AppointmentConnection.Appointments.Where(a => a.IdDoctor == id && a.state == 1).ToList();
            return View(appointments);
        }
        public ActionResult ListFinishedAppointmentDoctor()
        {
            string id = (string)Session["UserId"];
            var appointments = AppointmentConnection.Appointments.Where(a => a.IdDoctor == id && a.state==2).ToList();
            return View(appointments);
        }
        [HttpGet]
        public ActionResult EditCurrentAppointmentDoctor(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult EditCurrentAppointmentDoctor(Appointment Sc)
        {
            if (ModelState.IsValid)
            {
                AppointmentConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                AppointmentConnection.SaveChanges();
                return RedirectToAction("ListCurrentAppointmentDoctor");
            }
            return View();
        }
        public ActionResult FinishAppointmentDoctor(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            entry.state = 2;//Finished
            AppointmentConnection.SaveChanges();
            return RedirectToAction("ListCurrentAppointmentDoctor");
        }

        [HttpGet]
        public ActionResult DetailsCurrentAppointmentDoctor(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsCurrentAppointmentDoctor(Appointment Sc)
        {
            return View();
        }
        [HttpGet]
        public ActionResult DetailsSample(int Id)
        {
            SampleAppointment entry = SampleConnection.SampleAppointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsSample(SampleAppointment Sc)
        {
            return View();
        }

        [HttpGet]
        public ActionResult DetailsFinishedAppointmentDoctor(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsFinishedAppointmentDoctor(Appointment Sc)
        {
            return View();
        }
        [HttpGet]
        public ActionResult DetailsWaitingAppointmentDoctor(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsWaitingAppointmentDoctor(Appointment Sc)
        {
            return View();
        }
        #endregion

    }
}