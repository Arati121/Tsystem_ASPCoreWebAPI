using SampleWorkingWebAPI.Entities;
using SampleWorkingWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWorkingWebAPI.Repositories
{
    public class StudenttRepository : IStudenttRepository
    {
        RepositoriesContext context;
        public StudenttRepository(RepositoriesContext context) //DI
        {
            this.context = context;
        }
        public int AddStudentt(Studentt stud)
        {
            context.Students.Add(stud);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteStudentt(int rollno)
        {
            var stud = context.Students.Where(s => s.RollNo == rollno).SingleOrDefault();
            if (stud != null)
            {
                context.Students.Remove(stud);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Studentt> GetAllStudents()
        {
            return context.Students.ToList();
        }

            public int ModifyStudentt(Studentt stud)
        {
            var studentt = context.Students.Where(p => p.RollNo == stud.RollNo).SingleOrDefault();
            if (studentt != null)
            {
                studentt.Name = stud.Name;
                studentt.Percentage = stud.Percentage;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
