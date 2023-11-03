using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SMTIOnlineCourseRegistration.DAL;

namespace SMTIOnlineCourseRegistration.BLL
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<Student> GetAllStudents()
        {
            return StudentDB.GetAllRecords();
        }

        public Student SearchStudentById(int userUserId)
        {
            return StudentDB.GetStudent(userUserId);
        }
    }
}