using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    internal static class MasterManager
    {
        public static ManagerKurz Kurz = new ManagerKurz();
        public static ManagerStudent Student = new ManagerStudent();
        public static ManagerTeacher Teacher = new ManagerTeacher();
        public static ManagerGrades Grades = new ManagerGrades();


        //function for loggin in (used in the login form)
        public static Irole Login(string Username, string Password)
        {
            try
            {
                SqlConnection Conn = DBSingelton.GetInstance();

                //returns bollean depending on if login is valid
                SqlCommand Command = new SqlCommand($"exec checkUser @username='{Username}',@heslo='{Password}';", Conn);
                Command.ExecuteNonQuery();

                using (SqlDataReader reader = Command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        if (reader[3].ToString() == "student")
                        {
                            return Student.CreateNew(reader);
                        } 
                        else
                        {
                            return Teacher.CreateNew(reader);
                        }
                    }
                    else
                    {
                        throw new Exception("Username or password is wrong");
                    }

                }
                //trows if error on database side
                throw new Exception("Database Error please try again");
            }
            catch
            {
                throw new Exception("Couldn't connect to database");
            }
        }
    }
}
