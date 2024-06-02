using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV_Olsbro_2024
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                while (SharedVariables.Running) {
                    SharedVariables.Running = false;
                    Application.Run(new FormLogin());
                    if (SharedVariables.User != null)
                    {
                        Application.Run(new Form1());
                    }
                }
            }
            catch (Exception Ex)
            {
                Application.Run(new FormError());
            }
            
        }
    }
}
