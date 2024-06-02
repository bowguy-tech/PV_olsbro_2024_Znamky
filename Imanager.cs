using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    internal interface Imanager<T>
    {

        List<T> GetAll();
        T Get(int id);
        T CreateNew(SqlDataReader reader);

    }
}
