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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbox_pass.Text== txtbox_confpass.Text)
            {
                User_db udb = new User_db();
                udb.Username = txtbox_Username.Text;
                udb.Names = txtbox_name.Text;
                udb.Password = txtbox_pass.Text;
                udb.Usertype = combobox_usertype.Text;
                udb.Insertuser(udb);
                if (txtbox_Username.Text != "" && txtbox_name.Text != "" && txtbox_pass.Text != "")
                {
                    if (combobox_usertype.Text == "Admin")
                    {
                        mainpage mp = new mainpage();
                        mp.Show();
                    }
                    else if (combobox_usertype.Text == "Teacher")
                    {
                        Home hm = new Home();
                        hm.Show();
                    }
                    MessageBox.Show("Signup successful!!");

                }
                else
                    MessageBox.Show("Please fill all the entries....!!!");
               
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
