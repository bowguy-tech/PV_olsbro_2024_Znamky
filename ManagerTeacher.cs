using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    internal class ManagerTeacher : Imanager<InstanceTeacher>
    {
        public InstanceTeacher Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<InstanceTeacher> GetAll()
        {
            throw new NotImplementedException();
        }
        public InstanceTeacher CreateNew(SqlDataReader reader)
        {
            InstanceTeacher output = new InstanceTeacher(
                Int32.Parse(reader[0].ToString()),
                reader[1].ToString(),
                reader[2].ToString()
                );
            return output;
        }

    }
}
