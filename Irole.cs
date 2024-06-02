using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    internal interface Irole : Iinstance
    {
        //iterface for role (teacher/student)
        string FirstName { get; set; }
        string LastName { get; set; }
        
    }
}
