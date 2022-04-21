using SampleWorkingWebAPI.Model;
using SampleWorkingWebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWorkingWebAPI.Services
{
    public class StudenttService : IStudentServices
    {
        private readonly IStudenttRepository _iStudentRepo;
        public StudenttService(IStudenttRepository iStudentRepo)
        {
            _iStudentRepo = iStudentRepo;
        }
        public int AddStudentt(Studentt stud)
        {
            return _iStudentRepo.AddStudentt(stud);
        }

        public int DeleteStudentt(int rollno)
        {
            return _iStudentRepo.DeleteStudentt(rollno);
        }

        public IEnumerable<Studentt> GetAllStudents()
        {
            return _iStudentRepo.GetAllStudents();
        }

        public int ModifyStudentt(Studentt stud)
        {
            return _iStudentRepo.ModifyStudentt(stud);
        }
    }
}
