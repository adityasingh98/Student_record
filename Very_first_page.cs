using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSL0662_project
{
    public partial class Very_first_page : Form
    {
        public Very_first_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                login lg = new login();
                lg.Show();
            }
            else if (radioButton2.Checked)
            {
                Signup su = new Signup();
                su.Show();
            }
            else if (rbtn_chngpasssword.Checked)
            {
                change_password cp = new change_password();
                cp.Show();
            }
        }

        private void rbtn_chngpasssword_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
