using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    internal class InstanceKurz : Iinstance
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string SubjectShort { get; set; }

        public InstanceKurz(int ID,string Name,string Subject, String Short) {
            this.ID = ID;
            this.Name = Name;
            this.Subject = Subject;
            this.SubjectShort = Short;
        
        }
    }
}
