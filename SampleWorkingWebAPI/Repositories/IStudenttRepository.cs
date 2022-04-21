using SampleWorkingWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWorkingWebAPI.Repositories
{
   public interface IStudenttRepository
    {
        IEnumerable<Studentt> GetAllStudents();
        int AddStudentt(Studentt stud);
        int ModifyStudentt(Studentt stud);
        int DeleteStudentt(int rollno);
    }
}
