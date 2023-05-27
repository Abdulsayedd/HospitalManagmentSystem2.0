using HospitalManagmentSystem2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagmentSystem2._0.Controllers
{
    [Authorize]
    public class RadiologistController : Controller
    {
        AccountEntities AccountConnection = new AccountEntities();
        AppointmentEntities AppointmentConnection = new AppointmentEntities();
        ImageAppointmentEntities ImageConnection = new ImageAppointmentEntities();
        public ActionResult Index()
        {
            return View();
        }

        #region ListAppointmentTechnician
        public ActionResult ListAppointmentRadiologist()
        {
            return View(AppointmentConnection.Appointments.Where(a => (a.Imaging == null || a.Imaging == "") && a.state == 1).ToList());
        }
        #endregion

        #region recordsamples
        [HttpGet]
        public ActionResult RecordImaging(int id)
        {
            ImageAppointment model = new ImageAppointment { AppointmentID = id };
            return View(model);
        }
        [HttpPost]
        public ActionResult RecordImaging(ImageAppointment model)
        {
            if (ModelState.IsValid)
            {
                ImageConnection.ImageAppointments.Add(model);
                ImageConnection.SaveChanges();
                var entry = AppointmentConnection.Appointments.Find(model.AppointmentID);
                entry.Imaging = model.ImageID.ToString();
                AppointmentConnection.SaveChanges();
                return RedirectToAction("ListAppointmentRadiologist");
            }
            return View(model);
        }
        #endregion
    }
}