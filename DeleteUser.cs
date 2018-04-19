using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CSL0662_project
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            User_db udb = new User_db();
            udb.Username = combobox_deleteuser.Text;
            udb.DeleteUser(udb);
            MessageBox.Show("User Deleted succesfully!!!");
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            fillcbo();
        }
        public void fillcbo()
        {
            User_db udb = new User_db();
            udb.fillcombo(combobox_deleteuser);
        }
    }
}
