using HospitalManagmentSystem2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagmentSystem2._0.Controllers
{
    [Authorize]
    public class PharmacistController : Controller
    {
        MedicineEntities MedicineConnection = new MedicineEntities();
        AppointmentEntities AppointmentConnection = new AppointmentEntities();

        public ActionResult Index()
        {
            return View();
        }

        #region Appointment
        public ActionResult ListAppointmentsPharmacist()
        {
            return View(AppointmentConnection.Appointments.Where(a=>a.state==1).ToList());
        }
        #endregion


        #region Medicine
        public ActionResult ListMedicinesPharmacist()
        {
            return View(MedicineConnection.Medicines.ToList());
        }
        public ActionResult ListMedicinesPharmacist2(string name)
        {
            return View(MedicineConnection.Medicines.Where(a => a.MedicineName == name).ToList());
        }
        public ActionResult MedicineReduce(int Id)
        {
            var entry = MedicineConnection.Medicines.Find(Id);

            if (entry.MedicineCount > 0)entry.MedicineCount -= 1;
            MedicineConnection.SaveChanges();
            return RedirectToAction("ListMedicinesPharmacist");
        }
        #endregion
    }
}