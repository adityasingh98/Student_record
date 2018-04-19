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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User_db udb = new User_db();

            if (rbtn_admin.Checked)
            {
                udb.Usertype = "Admin";
            }
            else if (rbtn_user.Checked)
            {
                udb.Usertype = "Teacher";
            }
            udb.Username = txtbox_username.Text;
            udb.Password = txtbox_password.Text;

/*

            if (udb.Username == txtbox_username.Text)
            {
                if (udb.Password == txtbox_password.Text)
                {
                   
                }
            } 
 */
            if (udb.Authenticated(udb))
            {
                if (rbtn_admin.Checked)
                {
                    mainpage ud = new mainpage();
                    ud.Show();
                }
                else if(rbtn_user.Checked)
                {
                    userdisplay  hform= new userdisplay();
                    hform.Show();
                }
            }
            else
            {
                MessageBox.Show("Something has gone wrong,please fill the entries again!!");
            }
            

           

          
        }

        private void rbtn_user_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
