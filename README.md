# Hospital Management System (HMS) 🏥

A Hospital Management System (HMS) is a digital platform designed to streamline the operations and management of a hospital. It helps hospital managers to manage patient information, appointment scheduling, electronic medical records, inventory management, billing and payment processing, reporting and analytics, and other related tasks.

## System Actors 🎭

- **Receptionist:** Responsible for managing appointments.
- **Patient:** Can view, create, edit, and delete requested appointments and pays his bills.
- **Doctor:** Can write diagnoses and prescribe medications and confirm or edit the appointment.
- **Pharmacist:** Responsible for dispensing medications and managing inventory.
- **Lab Technician:** Manages samples, runs tests, and records results.
- **Radiologist:** Runs imaging and records results.
- **Managers:** Manages patient payments and employees' salaries and all information.
- **Administrator:** Manages everything.

**Note:** All system actors except patients can login to the system, while patients can login and register.

## Features ✨

- **Appointment Management:** Schedule and manage appointments.
- **Patient Information Management:** Store and manage patient information.
- **Electronic Medical Records (EMR):** Maintain electronic medical records for patients.
- **Inventory Management:** Manage inventory of medications and supplies.
- **Billing and Payment Processing:** Handle billing and payment processing for patients.

## Database Structure 📚

- **Account:** Stores user account information.
  - Columns: id, username, password, mail, name, age, address, mobilenumber, gender, type.
- **Salary:** Stores salary information for different roles.
  - Columns: id, salary.
- **Payment:** Stores payment information.
  - Columns: id, paid, amount.
- **Appointment:** Stores appointment details.
  - Columns: IdAppointment, IdPatient, IdDoc, date, medicine, samples, sample results, imaging, imaging results, diagnoses, state (finished or not).
- **Medicine:** Stores medicine inventory information.
  - Columns: IdMedicine, MedicineName, MedicineCount.

## User Permissions 👥

- **Patient:** Login, view, create, edit, and delete appointments, and pay bills.
- **Receptionist:** Login, view, create, edit, and delete appointments.
- **Doctor:** Login, view, create, edit, and delete appointments with details.
- **Technician:** Login, edit appointment samples and records.
- **Pharmacist:** Login, manage medicine inventory.
- **Nurses:** Login, view appointments.
- **Radiologist:** Login, run imaging, record results.
- **Managers:** Login, view, create, edit, and delete every database except admin.
- **Admin:** Login, view, create, edit, and delete every database.
