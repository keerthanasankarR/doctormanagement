using DoctorManagement.Model;
using DoctorManagement.Processor;
using DoctorManagement.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace DoctorManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IRepository _data;
        private readonly ILogger<DoctorController> _logger;
        public DoctorController(IRepository data, ILogger<DoctorController> logger)
        {
            _data = data;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GetPatientList()
        {
            List<DoctorDescription> lstdoctorDescription = null;
            try
            {
                lstdoctorDescription = _data.GetPatientList();
            }catch(Exception ex)
            {
                _logger.LogError("Exception occured at :",ex);
                

            }
            return Ok(lstdoctorDescription);
        }
        [HttpPost]
        public IActionResult Writedescription(DoctorDescription req)
        {
            bool response = false;
            try
            {
                response = _data.Writedescription(req);
            }catch(Exception ex)
            {
                _logger.LogError("Exception occured at :", ex);
            }
            return Ok(response);
        }

    }
}
