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
    public partial class UCkurzycs : UserControl
    {
        public UCkurzycs()
        {
            InitializeComponent();
        }

        private void UCkurzycs_Load(object sender, EventArgs e)
        {
            List<InstanceKurz> Kurzy = MasterManager.Kurz.GetAll();

            for (int i = 0; i < Kurzy.Count; i++)
            {
                AddKurz(Kurzy[i],i);
            }
        }

        private void AddKurz(InstanceKurz Kurz,int i)
        {
            UCkurz UC = new UCkurz();
            UC.Location = new Point(70,95 + (UC.Height + 10) * i);
            UC.Nazev = Kurz.Name;

            UC.button1.Click += (sender, e) => ButtonClick(sender, e, UC);

            this.Controls.Add(UC);
        }

        private void ButtonClick(object sender, EventArgs e, UCkurz UC)
        {

            Form1.navigate("znamky");
        }
    }
}
