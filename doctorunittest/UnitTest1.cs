using NUnit.Framework;
using DoctorManagement.Model;
using DoctorManagement.Processor;
using DoctorManagement.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;




namespace doctorunittest.Test
{
    [TestFixture]
    public class WriteDescEntityShould
    {
        [Test]
        public void CreateNew_WriteDesc_VieConstructor()
        {
            //Arrange
            //string ID = "123";
            string patientName = "Nik";
            //string patientAppointmentDate = "2022-07-13";
            string gender = "Male";
            string BloodGroup = "A";
            string EmailID = "Nik@gmail.com";
            string Phonenumber = "987654321";
            string DoctorType = "nik@gmail.com";
            string Description = "fever";
            string Technician = "scan";


            //Act
            DoctorManagement.Model.DoctorDescription test = new DoctorManagement.Model.DoctorDescription();
            //test. ID = ID;
            test. patientName = patientName;
            //test. patientAppointmentDate = patientAppointmentDate;
            test. gender = gender;
            test. BloodGroup = BloodGroup;
            test. EmailID = EmailID;
            test. Phonenumber = Phonenumber;
            test. DoctorType = DoctorType;
            test. Description = Description;
            test. Technician = Technician;

            //Assert
            Assert.That(test, Is.Not.Null);
            Assert.That(test, Is.InstanceOf<DoctorManagement.Model.DoctorDescription>());
            //Assert.That(test.ID, Is.EqualTo(ID));
            Assert.That(test.patientName, Is.EqualTo(patientName));
           // Assert.That(test.patientAppointmentDate, Is.EqualTo(patientAppointmentDate));
            Assert.That(test.gender, Is.EqualTo(gender));
            Assert.That(test.BloodGroup, Is.EqualTo(BloodGroup));
            Assert.That(test.EmailID, Is.EqualTo(EmailID));
            Assert.That(test.Phonenumber, Is.EqualTo(Phonenumber));
            Assert.That(test.DoctorType, Is.EqualTo(DoctorType));
            Assert.That(test.Description, Is.EqualTo(Description));
            Assert.That(test.Technician, Is.EqualTo(Technician));

        }
    }
}