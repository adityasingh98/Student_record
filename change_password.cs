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
    public partial class change_password : Form
    {
        public change_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_db udb = new User_db();
            udb.Username=txtbox_username.Text;
            udb.Password = txtbox_oldpassword.Text;

            if (txtbox_newpassword.Text == txtbox_conpassword.Text)
            {
                udb.Password = txtbox_conpassword.Text;
                udb.changepassword(udb);
                MessageBox.Show("Password succesfully changed!!!");

            }
            

        }
    }
}
