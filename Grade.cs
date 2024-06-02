using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    public class Grade : Iinstance
    {
        public int Value { get; set; }
        public int Weight { get; set; }
        public string Date { get; set; }
        public int ID { get; set; }

        public Grade(int value, int weight, string date)
        {
            Value = value;
            Weight = weight;
            Date = date;
        }
    }
}
