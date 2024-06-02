using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PV_Olsbro_2024
{
    internal class ManagerGrades
    {
        SqlConnection Conn;
        //gets all grades for all subject of a student
        public List<GradeGroup> getStudent(int ID)
        {
            List<GradeGroup> output = new List<GradeGroup>();

            using (Conn = DBSingelton.GetInstance())
            {
                SqlCommand Command = new SqlCommand("select Zak.jmeno,Zak.prijeni,Predmety.nazev,hodnota,vaha,datum from Znamka " +
                    "inner join Zak on zak.id = Znamka.zak_id " +
                    "inner join Kurz on Kurz.id = Znamka.kurz_id " +
                    "inner join Predmety on Predmety.id = Kurz.predmet_id " +
                    $"where Zak.id = {ID} " +
                    "order by Zak.jmeno,Zak.prijeni", Conn);

                Command.ExecuteNonQuery();
                using (SqlDataReader Reader = Command.ExecuteReader())
                {
                    string Category = "";
                    GradeGroup add = new GradeGroup();
                    while (Reader.Read())
                    {
                        if (Reader[2].ToString() != Category)
                        {
                            if (Category != "")
                            {
                                output.Add(add);
                            }
                            Category = Reader[2].ToString();
                            add = new GradeGroup();
                            add.Category = Category;
                        }
                        add.Grades.Add(new Grade(Int32.Parse(Reader[3].ToString()), Int32.Parse(Reader[3].ToString()), Reader[4].ToString()));

                    }
                    output.Add(add);
                }
                    
            }

            return output;
        }

        //gets all grades for all students in a course
        public GradeGroup getKurz(int ID)
        {
            throw new NotImplementedException();
        }

    }
}
