using HospitalManagmentSystem2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagmentSystem2._0.Controllers
{
    [Authorize]
    public class ManagerController : Controller
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
        public ActionResult ListAllAppointmentsManager()
        {
            return View(AppointmentConnection.Appointments.ToList());
        }
        [HttpGet]
        public ActionResult CreateAppointmentsManager()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAppointmentsManager(Appointment Sc)
        {
            if (ModelState.IsValid)
            {
                AppointmentConnection.Appointments.Add(Sc);
                AppointmentConnection.SaveChanges();
                return RedirectToAction("ListAllAppointmentsManager");
            }
            return View();
        }
        public ActionResult AcceptAppointmentManager(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            entry.state = 1;
            AppointmentConnection.SaveChanges();
            return RedirectToAction("ListAllAppointmentsManager");
        }
        [HttpGet]
        public ActionResult DetailsAppointmentManager(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsAppointmentManager(Appointment Sc)
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditAppointmentManager(int Id)
        {
            Appointment entry = AppointmentConnection.Appointments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult EditAppointmentManager(Appointment Sc)
        {
            if (ModelState.IsValid)
            {
                AppointmentConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                AppointmentConnection.SaveChanges();
                return RedirectToAction("ListAllAppointmentsManager");
            }
            return View();
        }
        public ActionResult DeleteAppointmentManager(int Id)
        {
            Appointment a = AppointmentConnection.Appointments.Find(Id);
            AppointmentConnection.Appointments.Remove(a);
            AppointmentConnection.SaveChanges();
            return RedirectToAction("ListAllAppointmentsManager");
        }
        #endregion


        #region Account

        public ActionResult ListAccountsManager()
        {
            return View(AccountConnection.Accounts.Where(a=>a.type!="Administrator"));
        }
        [HttpGet]
        public ActionResult DetailsAccountManager(int Id)
        {
            Account entry = AccountConnection.Accounts.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsAccountManager(Account Sc)
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditAccountManager(int Id)
        {
            Account entry = AccountConnection.Accounts.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult EditAccountManager(Account Sc)
        {
            if (ModelState.IsValid)
            {
                AccountConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                AccountConnection.SaveChanges();
                return RedirectToAction("ListAccountsManager");
            }
            return View();
        }
        [HttpGet]
        public ActionResult CreateAccountManager()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAccountManager(Account Sc)
        {
            if (ModelState.IsValid)
            {
                AccountConnection.Accounts.Add(Sc);
                AccountConnection.SaveChanges();
                return RedirectToAction("ListAccountsManager");
            }
            return View();
        }
        public ActionResult DeleteAccountManager(int Id)
        {
            Account a = AccountConnection.Accounts.Find(Id);
            AccountConnection.Accounts.Remove(a);
            AccountConnection.SaveChanges();
            return RedirectToAction("ListAccountsManager");
        }
        #endregion


        #region Payment
        public ActionResult ListPaymentsManager()
        {
            return View(PaymentConnection.Payments.ToList());
        }
        [HttpGet]
        public ActionResult DetailsPaymentManager(int Id)
        {
            Payment entry = PaymentConnection.Payments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsPaymentManager(Payment Sc)
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditPaymentManager(int Id)
        {
            Payment entry = PaymentConnection.Payments.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult EditPaymentManager(Payment Sc)
        {
            if (ModelState.IsValid)
            {
                PaymentConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                PaymentConnection.SaveChanges();
                return RedirectToAction("ListPaymentsManager");
            }
            return View();
        }
        [HttpGet]
        public ActionResult CreatePaymentManager()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatePaymentManager(Payment Sc)
        {
            if (ModelState.IsValid)
            {
                PaymentConnection.Payments.Add(Sc);
                PaymentConnection.SaveChanges();
                return RedirectToAction("ListPaymentsManager");
            }
            return View();
        }
        public ActionResult DeletePaymentManager(int Id)
        {
            Payment a = PaymentConnection.Payments.Find(Id);
            PaymentConnection.Payments.Remove(a);
            PaymentConnection.SaveChanges();
            return RedirectToAction("ListPaymentsManager");
        }

        #endregion


        #region Salary
        public ActionResult ListSalarysManager()
        {
            return View(SalaryConnection.Salaries.ToList());
        }
        [HttpGet]
        public ActionResult DetailsSalaryManager(int Id)
        {
            Salary entry = SalaryConnection.Salaries.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsSalaryManager(Salary Sc)
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditSalaryManager(int Id)
        {
            Salary entry = SalaryConnection.Salaries.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult EditSalaryManager(Salary Sc)
        {
            if (ModelState.IsValid)
            {
                SalaryConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                SalaryConnection.SaveChanges();
                return RedirectToAction("ListSalarysManager");
            }
            return View();
        }
        [HttpGet]
        public ActionResult CreateSalaryManager()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSalaryManager(Salary Sc)
        {
            if (ModelState.IsValid)
            {
                SalaryConnection.Salaries.Add(Sc);
                SalaryConnection.SaveChanges();
                return RedirectToAction("ListSalarysManager");
            }
            return View();
        }
        public ActionResult DeleteSalaryManager(int Id)
        {
            Salary a = SalaryConnection.Salaries.Find(Id);
            SalaryConnection.Salaries.Remove(a);
            SalaryConnection.SaveChanges();
            return RedirectToAction("ListSalarysManager");
        }

        #endregion


        #region Medicine
        public ActionResult ListMedicinesManager()
        {
            return View(MedicineConnection.Medicines.ToList());
        }
        [HttpGet]
        public ActionResult DetailsMedicineManager(int Id)
        {
            Medicine entry = MedicineConnection.Medicines.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult DetailsMedicineManager(Medicine Sc)
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditMedicineManager(int Id)
        {
            Medicine entry = MedicineConnection.Medicines.Find(Id);
            return View(entry);
        }
        [HttpPost]
        public ActionResult EditMedicineManager(Medicine Sc)
        {
            if (ModelState.IsValid)
            {
                MedicineConnection.Entry(Sc).State = System.Data.Entity.EntityState.Modified;
                MedicineConnection.SaveChanges();
                return RedirectToAction("ListMedicinesManager");
            }
            return View();
        }
        [HttpGet]
        public ActionResult CreateMedicineManager()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMedicineManager(Medicine Sc)
        {
            if (ModelState.IsValid)
            {
                MedicineConnection.Medicines.Add(Sc);
                MedicineConnection.SaveChanges();
                return RedirectToAction("ListMedicinesManager");
            }
            return View();
        }
        public ActionResult DeleteMedicineManager(int Id)
        {
            Medicine a = MedicineConnection.Medicines.Find(Id);
            MedicineConnection.Medicines.Remove(a);
            MedicineConnection.SaveChanges();
            return RedirectToAction("ListMedicinesManager");
        }

        #endregion

    }
}