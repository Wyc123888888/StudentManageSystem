using SMTIOnlineCourseRegistration.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SMTIOnlineCourseRegistration.BLL;

namespace SMTIOnlineCourseRegistration.DAL
{
    public class StudentDB
    {
        public static List<Student> GetAllRecords()
        {
            List<Student> listS = new List<Student>();
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                SqlCommand cmdAllStudent = new SqlCommand("SELECT * FROM Students", conn);
                SqlDataReader dReader = cmdAllStudent.ExecuteReader();
                Student student;
                while (dReader.Read())
                {
                    student = new Student
                    {
                        StudentId = Convert.ToInt32(dReader["StudentId"]),
                        FirstName = dReader["FirstName"].ToString(),
                        LastName = dReader["LastName"].ToString(),
                        Email = dReader["Email"].ToString()
                    };
                    listS.Add(student);
                }
            }

            return listS;
        }

        public static Student GetStudent(int sId)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                SqlCommand cmdStudent = new SqlCommand();
                cmdStudent.CommandText = "SELECT * FROM Students " +
                                         "WHERE StudentId = @StudentId";
                cmdStudent.Connection = conn;
                cmdStudent.Parameters.AddWithValue("@StudentId", sId);
                SqlDataReader dReader = cmdStudent.ExecuteReader();
                Student s = new Student();
                if (dReader.Read())
                {
                    s.StudentId = Convert.ToInt32(dReader["StudentId"]);
                    s.FirstName = dReader["FirstName"].ToString();
                    s.LastName = dReader["LastName"].ToString();
                    s.Email = dReader["Email"].ToString();
                }
                else
                {
                    s = null;
                }
                return s;
            }
        }

    }
}