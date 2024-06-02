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
    public partial class UCgradeLine : UserControl
    {
        public string NameText {  get => labelName.Text; set => labelName.Text = value; }
        public GradeGroup Grades { get; set; }
        public UCgradeLine()
        {
            InitializeComponent();
        }

        private void UCgradeLine_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Grades.Grades.Count; i++)
            {
                UCgradeBlock block = new UCgradeBlock();
                block.Location = new Point(105 + (block.Width + 10) * i, 10);
                block.Grade = Grades.Grades[i];
                this.Controls.Add(block);
            }
        }
    }
}
