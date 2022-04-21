using SampleWorkingWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWorkingWebAPI.Services
{
  public  interface IStudentServices
    {
        IEnumerable<Studentt> GetAllStudents();
        int AddStudentt(Studentt stud);
        int ModifyStudentt(Studentt stud);
        int DeleteStudentt(int rollno);
    }
}
