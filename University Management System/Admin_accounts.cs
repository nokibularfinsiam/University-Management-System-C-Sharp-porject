using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    public partial class Admin_accounts : Form
    {
        public Admin_accounts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_home Ah = new Admin_home();
            Ah.Show();
        }

        private void buttonDep_Click(object sender, EventArgs e)
        {
            Admin_department Ad = new Admin_department();
            Ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Faculty Af = new Admin_Faculty();
            Af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Students As = new Admin_Students();
            As.Show();
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            Admin_Courses Ac = new Admin_Courses();
            Ac.Show();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
