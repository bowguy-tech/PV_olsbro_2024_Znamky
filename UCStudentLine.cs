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
    public partial class UCStudentLine : UserControl
    {
        public string NameText { get => labelName.Text; set => labelName.Text = value; }
        public UCStudentLine()
        {
            InitializeComponent();
        }

        private void UCStudentLine_Load(object sender, EventArgs e)
        {

        }
    }
}
