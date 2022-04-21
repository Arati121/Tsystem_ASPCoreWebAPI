using Microsoft.AspNetCore.Mvc;
using SampleWorkingWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWorkingWebAPI.Controllers
{
    public class StudenttController : Controller
    {
       private readonly IStudentsServices _studservice;
        public StudenttController(IStudentsServices studservice)
        {
            _studservice = studservice;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Studentt/GetStudents")]
        public IActionResult GetStudents()
        {
            return new ObjectResult(_studservice.GetAllStudents());
        }
        [HttpPost]
        [Route("AddStudentt")]
        public IActionResult AddStudentt(Studentt stud)
        {
            return new ObjectResult(_studservice.AddStudentt(stud));
        }

        [HttpPost]
        [Route("ModifyStudentt")]
        public IActionResult ModifyStudentt(Studentt stud)
        {
            return new ObjectResult(_studservice.ModifyStudentt(stud));
        }

        [HttpGet]
        [Route("DeleteStudentt/{id}")]
        public IActionResult DeleteStudentt(int id)
        {
            return new ObjectResult(_studservice.DeleteStudentt(id));
        }
    }
}
