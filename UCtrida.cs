using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV_Olsbro_2024
{
    public partial class UCtrida : UserControl
    {
        public UCtrida()
        {
            InitializeComponent();
        }

        private void UCtrida_Load(object sender, EventArgs e)
        {

            if (SharedVariables.User is InstanceTeacher)
            {
                List<InstanceStudent> students = MasterManager.Student.GetClass((InstanceTeacher)SharedVariables.User);
                for (int i = 0; i < students.Count; i++)
                {
                    UCStudentLine GL = new UCStudentLine();
                    GL.Location = new Point(70, 95 + (GL.Height + 10) * i);
                    GL.NameText = students[i].FirstName + " " + students[i].LastName;

                    GL.button1.Click += (sinder,j) => ButtonClick(sender,e,GL);

                    this.Controls.Add(GL);
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e, UCStudentLine UL)
        {

            Form1.navigate("znamky");
        }
    }
}
