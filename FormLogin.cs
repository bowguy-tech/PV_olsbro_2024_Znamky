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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SharedVariables.User = MasterManager.Login(InputUsername.Text, InputPassword.Text);
                if (SharedVariables.User != null)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
            }
            
        }

    }
}
