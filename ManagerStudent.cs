using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    internal class ManagerStudent : Imanager<InstanceStudent>
    {
        SqlConnection Conn;
        SqlDataReader reader;
        public InstanceStudent Get(int id)
        {
            InstanceStudent output;
            using (Conn = DBSingelton.GetInstance())
            {
                SqlCommand command = new SqlCommand(
                    "select Zak.id,Zak.jmeno,Zak.prijeni,Trida.id,Trida.rocnik,Obory.zkratka,Obory.nazev,Ucitel.id,Ucitel.jmeno,Ucitel.prijeni from Zak" +
                    "inner join Trida on trida.id = Zak.trida_id" +
                    "inner join Obory on Obory.id = obor_id" +
                    "inner join Ucitel on Ucitel.id = tridni_id" +
                    $"where Zak.id = {id};", Conn);

                command.ExecuteNonQuery();

                using (reader = command.ExecuteReader())
                {
                    output = CreateNew(reader);
                    
                }
            }
            reader.Close();
            return output;
        }

        public List<InstanceStudent> GetClass(InstanceTeacher teacher)
        {
            List<InstanceStudent> output = new List<InstanceStudent>();
            using (Conn = DBSingelton.GetInstance())
            {
                SqlCommand command = new SqlCommand(
                    "select Zak.id,Zak.jmeno,Zak.prijeni,Trida.id,Trida.rocnik,Obory.zkratka,Obory.nazev,Ucitel.id,Ucitel.jmeno,Ucitel.prijeni from Zak " +
                    "inner join Trida on Zak.trida_id = Trida.id " +
                    "inner join Obory on Trida.obor_id = Obory.id " +
                    "inner join Ucitel on Ucitel.id = Trida.tridni_id " +
                    $"where Ucitel.id = {teacher.ID};", Conn);

                command.ExecuteNonQuery();

                using (SqlDataReader reader2 = command.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        output.Add(CreateNew(reader2));
                    }

                }
            }
            return output;
        }

        public List<InstanceStudent> GetAll()
        {
            throw new NotImplementedException();
        }

        public InstanceStudent CreateNew(SqlDataReader reader)
        {
            InstanceStudent output = new InstanceStudent(
                Int32.Parse(reader[0].ToString()),
                reader[1].ToString(),
                reader[2].ToString()
                );
            return output;
        }
    }
}
