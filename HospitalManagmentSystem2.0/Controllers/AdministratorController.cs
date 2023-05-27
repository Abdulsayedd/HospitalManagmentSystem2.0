
using HospitalManagmentSystem2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagmentSystem2._0.Controllers
{
    [Authorize]
    public class AdministratorController : Controller
    {
        
        #region Base
        AccountEntities AccountConnection = new AccountEntities();
        AppointmentEntities AppointmentConnection = new AppointmentEntities();
        PaymentEntities PaymentConnection = new PaymentEntities();
        SalaryEntities SalaryConnection = new SalaryEntities();
        MedicineEntities MedicineConnection = new MedicineEntities();
        public ActionResult Index()
        {
            return View();
        } 
        #endregion


        #region ManageAppointments
        public ActionResult ListAllAppointmentsAdministrator()
        {
            return View(AppointmentConnection.Appointments.ToList());
        }
        [HttpGet]
        public ActionResult CreateAppointmentsAdministrator()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAppointmentsAdministrator(Appointment Sc)
        {
            if (ModelState.IsValid)
            {
                AppointmentConnection.Appointments.Add(Sc);
                AppointmentConnection.SaveChanges();
                return RedirectToAction("ListAllAppointmentsAdministrator");
            }
            return View();
        }
        public ActionResult AcceptAppointmentAdministrator(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            entry.state = 1;
            AppointmentConnection.SaveChanges();
            return RedirectToAction("ListAllAppointmentsAdministrator");
        }
        [HttpGet]
        public ActionResult DetailsAppointmentAdministrator(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsAppointmentAdministrator(Appointment Sc)
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditAppointmentAdministrator(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult EditAppointmentAdministrator(Appointment Sc)
        {
            if (ModelState.IsValid)
            {
                AppointmentConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                AppointmentConnection.SaveChanges();
                return RedirectToAction("ListAllAppointmentsAdministrator");
            }
            return View();
        }
        public ActionResult DeleteAppointmentAdministrator(int Id)
        {
            Appointment a = AppointmentConnection.Appointments.Find(Id);
            AppointmentConnection.Appointments.Remove(a);
            AppointmentConnection.SaveChanges();
            return RedirectToAction("ListAllAppointmentsAdministrator");
        }
        #endregion


        #region Account

        public ActionResult ListAccountsAdministrator()
        {
            return View(AccountConnection.Accounts.ToList());
        }
        [HttpGet]
        public ActionResult DetailsAccountAdministrator(int Id)
        {
            Account entry = AccountConnection.Accounts.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsAccountAdministrator(Account Sc)
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditAccountAdministrator(int Id)
        {
            Account entry = AccountConnection.Accounts.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult EditAccountAdministrator(Account Sc)
        {
            if (ModelState.IsValid)
            {
                AccountConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                AccountConnection.SaveChanges();
                return RedirectToAction("ListAccountsAdministrator");
            }
            return View();
        }
        [HttpGet]
        public ActionResult CreateAccountAdministrator()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAccountAdministrator(Account Sc)
        {
            if (ModelState.IsValid)
            {
                AccountConnection.Accounts.Add(Sc);
                AccountConnection.SaveChanges();
                return RedirectToAction("ListAccountsAdministrator");
            }
            return View();
        }
        public ActionResult DeleteAccountAdministrator(int Id)
        {
            Account a = AccountConnection.Accounts.Find(Id);
            AccountConnection.Accounts.Remove(a);
            AccountConnection.SaveChanges();
            return RedirectToAction("ListAccountsAdministrator");
        }
        #endregion


        #region Payment
        public ActionResult ListPaymentsAdministrator()
        {
            return View(PaymentConnection.Payments.ToList());
        }
        [HttpGet]
        public ActionResult DetailsPaymentAdministrator(int Id)
        {
            Payment entry = PaymentConnection.Payments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsPaymentAdministrator(Payment Sc)
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditPaymentAdministrator(int Id)
        {
            Payment entry = PaymentConnection.Payments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult EditPaymentAdministrator(Payment Sc)
        {
            if (ModelState.IsValid)
            {
                PaymentConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                PaymentConnection.SaveChanges();
                return RedirectToAction("ListPaymentsAdministrator");
            }
            return View();
        }
        [HttpGet]
        public ActionResult CreatePaymentAdministrator()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatePaymentAdministrator(Payment Sc)
        {
            if (ModelState.IsValid)
            {
                PaymentConnection.Payments.Add(Sc);
                PaymentConnection.SaveChanges();
                return RedirectToAction("ListPaymentsAdministrator");
            }
            return View();
        }
        public ActionResult DeletePaymentAdministrator(int Id)
        {
            Payment a = PaymentConnection.Payments.Find(Id);
            PaymentConnection.Payments.Remove(a);
            PaymentConnection.SaveChanges();
            return RedirectToAction("ListPaymentsAdministrator");
        }

        #endregion


        #region Salary
        public ActionResult ListSalarysAdministrator()
        {
            return View(SalaryConnection.Salaries.ToList());
        }
        [HttpGet]
        public ActionResult DetailsSalaryAdministrator(int Id)
        {
            Salary entry = SalaryConnection.Salaries.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsSalaryAdministrator(Salary Sc)
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditSalaryAdministrator(int Id)
        {
            Salary entry = SalaryConnection.Salaries.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult EditSalaryAdministrator(Salary Sc)
        {
            if (ModelState.IsValid)
            {
                SalaryConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                SalaryConnection.SaveChanges();
                return RedirectToAction("ListSalarysAdministrator");
            }
            return View();
        }
        [HttpGet]
        public ActionResult CreateSalaryAdministrator()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSalaryAdministrator(Salary Sc)
        {
            if (ModelState.IsValid)
            {
                SalaryConnection.Salaries.Add(Sc);
                SalaryConnection.SaveChanges();
                return RedirectToAction("ListSalarysAdministrator");
            }
            return View();
        }
        public ActionResult DeleteSalaryAdministrator(int Id)
        {
            Salary a = SalaryConnection.Salaries.Find(Id);
            SalaryConnection.Salaries.Remove(a);
            SalaryConnection.SaveChanges();
            return RedirectToAction("ListSalarysAdministrator");
        }

        #endregion


        #region Medicine
        public ActionResult ListMedicinesAdministrator()
        {
            return View(MedicineConnection.Medicines.ToList());
        }
        [HttpGet]
        public ActionResult DetailsMedicineAdministrator(int Id)
        {
            Medicine entry = MedicineConnection.Medicines.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsMedicineAdministrator(Medicine Sc)
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditMedicineAdministrator(int Id)
        {
            Medicine entry = MedicineConnection.Medicines.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult EditMedicineAdministrator(Medicine Sc)
        {
            if (ModelState.IsValid)
            {
                MedicineConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                MedicineConnection.SaveChanges();
                return RedirectToAction("ListMedicinesAdministrator");
            }
            return View();
        }
        [HttpGet]
        public ActionResult CreateMedicineAdministrator()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMedicineAdministrator(Medicine Sc)
        {
            if (ModelState.IsValid)
            {
                MedicineConnection.Medicines.Add(Sc);
                MedicineConnection.SaveChanges();
                return RedirectToAction("ListMedicinesAdministrator");
            }
            return View();
        }
        public ActionResult DeleteMedicineAdministrator(int Id)
        {
            Medicine a = MedicineConnection.Medicines.Find(Id);
            MedicineConnection.Medicines.Remove(a);
            MedicineConnection.SaveChanges();
            return RedirectToAction("ListMedicinesAdministrator");
        }

        #endregion

       


    }
}