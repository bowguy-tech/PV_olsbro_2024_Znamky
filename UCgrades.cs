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
    public partial class UCgrades : UserControl
    {
        public UCgrades()
        {
            InitializeComponent();
        }

        private void UCgrades_Load(object sender, EventArgs e)
        {
            if (SharedVariables.GradeType == "Student")
                
            {
                List<GradeGroup> Grades = MasterManager.Grades.getStudent(SharedVariables.GradeId);
                for (int i = 0; i < Grades.Count; i++)
                {
                    UCgradeLine GL = new UCgradeLine();
                    GL.Location = new Point(70, 95 + (GL.Height + 10) * i);
                    GL.NameText = Grades[i].Category;
                    GL.Grades = Grades[i];
                    this.Controls.Add(GL);
                }
            }
        }
    }
}
