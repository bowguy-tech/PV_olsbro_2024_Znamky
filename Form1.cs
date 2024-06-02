using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace PV_Olsbro_2024
{
    public partial class Form1 : Form
    {
        static Dictionary<string, UserControl> Pages = new Dictionary<string, UserControl>();

        //function to navigate between the "pages"(user controls)
        public static void navigate(string Path)
        {
                Dictionary<string, UserControl>.ValueCollection Values = Pages.Values;
                foreach (UserControl V in Values)
                {
                    V.Visible = false;
                }
            Pages[Path].Visible = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
            Pages.Add("kurzy", this.uCkurzycs1);
            Pages.Add("znamky", this.uCznamky1);
            Pages.Add("trida", this.uCtrida1);
            } 
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navigate("kurzy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (SharedVariables.User is InstanceTeacher)
            {
                navigate("trida");
            } 
            else
            {
                navigate("znamky");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            SharedVariables.Running = true;
            SharedVariables.User = null;
            this.Close();
        }

        private void uCtrida1_Load(object sender, EventArgs e)
        {

        }
    }
}
