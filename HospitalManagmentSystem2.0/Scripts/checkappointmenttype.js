// Get the button elements
var pageLink1 = document.getElementById("patientappointment");
var pageLink2 = document.getElementById("listdoctorallappointment");
var pageLink3 = document.getElementById("pharmacistappointment");
var pageLink4 = document.getElementById("pharmacistmedicine");
var pageLink5 = document.getElementById("receptionistappointment");
var pageLink6 = document.getElementById("receptionistpayment");
var pageLink7 = document.getElementById("technicianappointment");
var pageLink8 = document.getElementById("technicianrecord");
var pageLink9 = document.getElementById("radiologistappointment");
var pageLink10 = document.getElementById("radiologistrecord");
var pageLink11 = document.getElementById("nurseappointment");
var pageLink12 = document.getElementById("managerappointment");
var pageLink13 = document.getElementById("manageraccount");
var pageLink14 = document.getElementById("managerpayment");
var pageLink15 = document.getElementById("managersalary");
var pageLink16 = document.getElementById("managermedicine");
var pageLink17 = document.getElementById("administratorappointment");
var pageLink18 = document.getElementById("administratoraccount");
var pageLink19 = document.getElementById("administratorpayment");
var pageLink20 = document.getElementById("administratorsalary");
var pageLink21 = document.getElementById("administratormedicine");
var pageLink22 = document.getElementById("administratormanagers");
var pageLink23 = document.getElementById("listdoctorcurrentappointment");
var pageLink24 = document.getElementById("listdoctorwaitingappointment");
var pageLink25 = document.getElementById("listdoctorfinishedappointment");

var userType = pageLink1.getAttribute("data-usertype");

pageLink1.style.display = "none";
pageLink2.style.display = "none";
pageLink3.style.display = "none";
pageLink4.style.display = "none";
pageLink5.style.display = "none";
pageLink6.style.display = "none";
pageLink7.style.display = "none";
pageLink8.style.display = "none";
pageLink9.style.display = "none";
pageLink10.style.display = "none";
pageLink11.style.display = "none";
pageLink12.style.display = "none";
pageLink13.style.display = "none";
pageLink14.style.display = "none";
pageLink15.style.display = "none";
pageLink16.style.display = "none";
pageLink17.style.display = "none";
pageLink18.style.display = "none";
pageLink19.style.display = "none";
pageLink20.style.display = "none";
pageLink21.style.display = "none";
pageLink22.style.display = "none";
pageLink23.style.display = "none";
pageLink24.style.display = "none";
pageLink25.style.display = "none";

if (userType === "Patient")
{
    pageLink1.href = "/Patient/ListAppointmentPatient";
    pageLink1.style.display = "inline-block";
}

if (userType === "Receptionist") {
    pageLink5.href = "/Reciptionist/ListAppointmentReceptionist";
    pageLink6.href = "/Reciptionist/ListPaymentReceptionist";
    pageLink5.style.display = "inline-block";
    pageLink6.style.display = "inline-block";
}

if (userType === "Doctor")
{
    pageLink2.href = "/Doctor/ListAllAppointmentDoctor";
    pageLink23.href = "/Doctor/ListCurrentAppointmentDoctor";
    pageLink24.href = "/Doctor/ListWaitingAppointmentDoctor";
    pageLink25.href = "/Doctor/ListFinishedAppointmentDoctor";
    pageLink2.style.display = "inline-block";
    pageLink23.style.display = "inline-block";
    pageLink24.style.display = "inline-block";
    pageLink25.style.display = "inline-block";
}
if (userType === "Pharmacist")
{
    pageLink3.href = "/Pharmacist/ListAppointmentsPharmacist";
    pageLink4.href = "/Pharmacist/ListMedicinesPharmacist";
    pageLink3.style.display = "inline-block";
    pageLink4.style.display = "inline-block";
}



if (userType === "Technician") {
    pageLink7.href = "/LabTechnician/ListAppointmentTechnician";
    pageLink8.href = "/LabTechnician/RecordSamples";
    pageLink7.style.display = "inline-block";
    pageLink8.style.display = "inline-block";
}

if (userType === "Radiologist")
{
    pageLink9.href = "/Radiologist/ListAppointmentRadiologist";
    pageLink10.href = "/Radiologist/RecordImaging";
    pageLink9.style.display = "inline-block";
    pageLink10.style.display = "inline-block";
}

if (userType === "Nurse") {
    pageLink11.href = "ListNurseAppointment";
    pageLink11.style.display = "inline-block";
}
if (userType === "Manager")
{
    pageLink12.href = "/Manager/ListAllAppointmentsManager";
    pageLink13.href = "/Manager/ListAccountsManager";
    pageLink14.href = "/Manager/ListPaymentsManager";
    pageLink15.href = "/Manager/ListSalarysManager";
    pageLink16.href = "/Manager/ListMedicinesManager";
    pageLink12.style.display = "inline-block";
    pageLink13.style.display = "inline-block";
    pageLink14.style.display = "inline-block";
    pageLink15.style.display = "inline-block";
    pageLink16.style.display = "inline-block";
}

if (userType === "Administrator")
{
    pageLink17.href = "/Administrator/ListAllAppointmentsAdministrator";
    pageLink18.href = "/Administrator/ListAccountsAdministrator";
    pageLink19.href = "/Administrator/ListPaymentsAdministrator";
    pageLink20.href = "/Administrator/ListSalarysAdministrator";
    pageLink21.href = "/Administrator/ListMedicinesAdministrator";
    pageLink17.style.display = "inline-block";
    pageLink18.style.display = "inline-block";
    pageLink19.style.display = "inline-block";
    pageLink20.style.display = "inline-block";
    pageLink21.style.display = "inline-block";
}

if (userType === null)
{
    pageLink1.style.display = "none";
    pageLink2.style.display = "none";
    pageLink3.style.display = "none";
    pageLink4.style.display = "none";
    pageLink5.style.display = "none";
    pageLink6.style.display = "none";
    pageLink7.style.display = "none";
    pageLink8.style.display = "none";
    pageLink9.style.display = "none";
    pageLink10.style.display = "none";
    pageLink11.style.display = "none";
    pageLink12.style.display = "none";
    pageLink13.style.display = "none";
    pageLink14.style.display = "none";
    pageLink15.style.display = "none";
    pageLink16.style.display = "none";
    pageLink17.style.display = "none";
    pageLink18.style.display = "none";
    pageLink19.style.display = "none";
    pageLink20.style.display = "none";
    pageLink21.style.display = "none";
    pageLink22.style.display = "none";
}