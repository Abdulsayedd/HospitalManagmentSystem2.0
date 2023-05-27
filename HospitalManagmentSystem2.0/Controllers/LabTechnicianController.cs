using HospitalManagmentSystem2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagmentSystem2._0.Controllers
{
    [Authorize]
    public class LabTechnicianController : Controller
    {
        AccountEntities AccountConnection = new AccountEntities();
        AppointmentEntities AppointmentConnection = new AppointmentEntities();
        SampleAppointmentEntities SampleConnection = new SampleAppointmentEntities();
        public ActionResult Index()
        {
            return View();
        }
        #region ListAppointmentTechnician
        public ActionResult ListAppointmentTechnician()
        {
            return View(AppointmentConnection.Appointments.Where(a=>(a.Samples==null || a.Samples=="")&&a.state==1 ).ToList());
        }
        #endregion
        #region recordsamples
        [HttpGet]
        public ActionResult RecordSample(int id)
        {
            SampleAppointment model = new SampleAppointment{AppointmentID = id};
            return View(model);
        }

        [HttpPost]
        public ActionResult RecordSample(SampleAppointment model)
        {

            if (ModelState.IsValid)
            {
                SampleConnection.SampleAppointments.Add(model);
                SampleConnection.SaveChanges();
                var entry = AppointmentConnection.Appointments.Find(model.AppointmentID);
                entry.Samples = model.SampleID.ToString();
                AppointmentConnection.SaveChanges();
                return RedirectToAction("ListAppointmentTechnician");
            }
            return View(model);
        }
        #endregion
    }
}