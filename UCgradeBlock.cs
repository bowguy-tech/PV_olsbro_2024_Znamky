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
    public partial class UCgradeBlock : UserControl
    {
        public Grade Grade { get; set; }

        public UCgradeBlock()
        {
            InitializeComponent();
        }

        private void UCgradeBlock_Load(object sender, EventArgs e)
        {
            this.labelValue.Text = Grade.Value.ToString();
            switch (Grade.Value)
            {
                case 0:
                    this.BackColor = Color.LightGray;
                    break;
                case 5:
                    this.BackColor = Color.Red;
                    break;
                case 4:
                    this.BackColor = Color.Orange;
                    break;
                case 3:
                    this.BackColor = Color.Yellow;
                    break;
                case 2:
                    this.BackColor = Color.LightGreen;
                    break;
                case 1:
                    this.BackColor = Color.Green;
                    break;
            }
            
        }

        private void labelValue_Click(object sender, EventArgs e)
        {

        }
    }
}
