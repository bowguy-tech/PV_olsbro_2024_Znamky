using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    internal class InstanceTeacher : Irole
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        
        public InstanceTeacher(int ID, string FirstName, string LastName)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
