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
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signup su = new Signup();
            su.Show();
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser du = new DeleteUser();
            du.Show();
        }

        private void displayStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
        }

        private void displayUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signup su = new Signup();
            su.Show();
        }

        private void displayTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userdisplay ud = new userdisplay();
            ud.Show();
        }

        private void mainpage_Load(object sender, EventArgs e)
        {

        }
    }
}
