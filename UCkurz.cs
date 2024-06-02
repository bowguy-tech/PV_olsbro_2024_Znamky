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
    public partial class UCkurz : UserControl
    {
        public UCkurz()
        {
            InitializeComponent();
        }
        public string Nazev
        {
            get { return labelNazev.Text; }
            set { labelNazev.Text = value; }
        }

        private void UCkurz_Load(object sender, EventArgs e)
        {
            if (SharedVariables.User is InstanceStudent)
            {
                this.button1.Visible = false;
            }
            this.button1.Visible = false;
        }


    }
}
