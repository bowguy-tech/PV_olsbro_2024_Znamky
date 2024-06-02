using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    public class GradeGroup
    {
        public String Category { get; set; }
        public List<Grade> Grades { get; set; } = new List<Grade>();
    }
}
