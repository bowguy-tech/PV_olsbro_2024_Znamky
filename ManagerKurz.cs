using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PV_Olsbro_2024
{
    internal class ManagerKurz : Imanager<InstanceKurz>
    {
        SqlConnection Conn;
        SqlDataReader reader;
        public InstanceKurz Get(int id)
        {
            InstanceKurz output;
            using (Conn = DBSingelton.GetInstance())
            {
                SqlCommand command = new SqlCommand("select Kurz.id,Kurz.nazev,Predmety.nazev as predmet,zkratka from Kurz" +
                    $" inner join Predmety on Predmety.id = Kurz.predmet_id where Kurz.id = {id};", Conn);
                command.ExecuteNonQuery();

                using (reader = command.ExecuteReader())
                {
                    output = CreateNew(reader);
                }
            }
            return output;
        }

        public List<InstanceKurz> GetAll()
        {
            List<InstanceKurz> output = new List<InstanceKurz>();
            using (Conn = DBSingelton.GetInstance())
            {
                SqlCommand command = new SqlCommand();
                if (SharedVariables.User is InstanceStudent)
                {
                    command = new SqlCommand("select Kurz.id,Kurz.nazev,Predmety.nazev as predmet,zkratka from Kurz " +
                        "inner join Predmety on Predmety.id = Kurz.predmet_id " +
                        "inner join Studuje on Studuje.kurz_id = Kurz.id " +
                        "inner join Zak on Zak.id = Studuje.zak_id " +
                        $"where Zak.id = {SharedVariables.User.ID}", Conn);
                } 
                else if (SharedVariables.User is InstanceTeacher)
                {
                    command = new SqlCommand("select Kurz.id,Kurz.nazev,Predmety.nazev as predmet,zkratka from Kurz " +
                        "inner join Predmety on Predmety.id = Kurz.predmet_id " +
                        "inner join Uci on Uci.kurz_id = Kurz.id " +
                        "inner join Ucitel on Uci.ucitel_id = Ucitel.id " +
                        $"where Ucitel.id = {SharedVariables.User.ID}", Conn);
                }
                
                command.ExecuteNonQuery();

                using (reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        output.Add(CreateNew(reader));
                    }
                }
            }
            return output;
        }
        
        public InstanceKurz CreateNew(SqlDataReader reader)
        {
            InstanceKurz output = new InstanceKurz(
                Int32.Parse(reader[0].ToString()),
                reader[1].ToString(),
                reader[2].ToString(),
                reader[3].ToString()
                );
            return output;
        }
    }
}
