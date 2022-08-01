using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorManagement.Model
{
    public class DoctorDescription
    {

        public int ID { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string patientName { get; set; }

        public string PatientApppointmentDate { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string gender { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string BloodGroup { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string EmailID { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Phonenumber { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string DoctorType { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Description { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Technician { get; set; }
        


    }
}


