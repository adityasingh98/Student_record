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
    public partial class userdisplay : Form
    {
        public userdisplay()
        {
            InitializeComponent();
        }

        private void userdisplay_Load(object sender, EventArgs e)
        {
            User_db udb = new User_db();
            udb.getdata(dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            User_db udb = new User_db();

            udb.getdatabysearch(dataGridView1,textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

              
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
