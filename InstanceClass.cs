using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    internal class InstanceClass : Iinstance
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public List<InstanceStudent> Students { get; set; } = new List<InstanceStudent>();

        public InstanceClass(int ID,String Name, String Specialization) {
            this.ID = ID;
            this.Name = Name;
            this.Specialization = Specialization;
        }
    }
}
