using DoctorManagement.EntityData;
using DoctorManagement.Model;
using DoctorManagement.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoctorManagement.Processor
{
    public class DataProcessor : IRepository
    {
        private DoctorContext _data;
        private readonly ILogger<DataProcessor> _logger;
        public DataProcessor(DoctorContext data, ILogger<DataProcessor> logger)
        {
            _data = data; 
            _logger = logger;
        }
        public List<DoctorDescription> GetPatientList()
        {
            IEnumerable<DoctorDescription> patientlst = null;
            try
            {
                patientlst = _data._doctorContext;
            }catch(Exception ex)
            {
                _logger.LogError("Exception occured at :",ex);
            }
            return patientlst.ToList();
        }

        public bool Writedescription(DoctorDescription req)
        {
            bool response = false;
            int flag = 0;
            DoctorDescription descInfo = new DoctorDescription();
           //try
            {

                //descInfo = _data._doctorContext.Find(req.ID);
                descInfo.Technician = req.Technician;
                descInfo.Description = req.Description;
                //_data._doctorContext = descInfo;
                descInfo.patientName = req.patientName;
                descInfo.PatientApppointmentDate = req.PatientApppointmentDate;
                descInfo.gender = req.gender;
                descInfo.BloodGroup = req.BloodGroup;
                descInfo.EmailID = req.EmailID;
                descInfo.Phonenumber = req.Phonenumber;
                descInfo.DoctorType = req.DoctorType;





                 _data._doctorContext.Add(descInfo);
                
                flag = _data.SaveChanges();
                if (flag > 0)
                {
                    response = true;
                }                
            }
            /*catch (Exception ex)
            {
                _logger.LogError("Exception occured at :", ex);
            }*/
            return response;
        }
    }
}
