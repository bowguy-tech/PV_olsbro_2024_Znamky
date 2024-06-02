using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Olsbro_2024
{
    //class fr sharing variables between forms/user controls/ etc..
    internal static class SharedVariables
    {
        //this is the stored user after loggin in 
        //if User is null = logged out
        public static Irole User {  get; set; }
        public static bool Running { get; set; } = true;

        //variables for the grade page
        public static String GradeType { get; set; } = "Student"; //TEMP
        public static int GradeId { get; set; } = 1; //TEMP
    }
}
