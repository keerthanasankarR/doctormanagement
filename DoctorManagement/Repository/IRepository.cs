using DoctorManagement.Model;
using System.Collections.Generic;

namespace DoctorManagement.Repository
{
    public interface IRepository
    {
        List<DoctorDescription> GetPatientList();
        bool Writedescription(DoctorDescription req);

    }
}
