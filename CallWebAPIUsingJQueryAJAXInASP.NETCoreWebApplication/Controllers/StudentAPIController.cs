using CallWebAPIUsingJQueryAJAXInASP.NETCoreWebApplication.Models.Student;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallWebAPIUsingJQueryAJAXInASP.NETCoreWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : Controller
    {
        // GET: api/GetAllStudents  
        [HttpGet]
        public IEnumerable<PersonalDetail> GetAllStudents()
        {
            List<PersonalDetail> students = new List<PersonalDetail>
           {
           new PersonalDetail{
                              RegNo = "2017-0001",
                              Name = "Nishan",
                              Address = "Kathmandu",
                              PhoneNo = "9849845061",
                              AdmissionDate = DateTime.Now
                              },
           new PersonalDetail{
                              RegNo = "2017-0002",
                              Name = "Namrata Rai",
                              Address = "Bhaktapur",
                              PhoneNo = "9849845062",
                              AdmissionDate = DateTime.Now
                             },
           };
            return students;
        }
    }


}
