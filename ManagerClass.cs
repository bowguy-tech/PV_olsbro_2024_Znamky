using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    internal class ManagerClass : Imanager<InstanceClass>
    {
        public InstanceClass Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<InstanceClass> GetAll()
        {
            throw new NotImplementedException();
        }
        public InstanceClass CreateNew(SqlDataReader reader)
        {
            InstanceClass output = new InstanceClass(
                Int32.Parse(reader[0].ToString()),
                reader[1].ToString() + reader[2].ToString(),
                reader[3].ToString()
                );
            return output;
        }
    }
}
