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
    public partial class Admin_Courses : Form
    {
        public Admin_Courses()
        {
            InitializeComponent();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_home Ah = new Admin_home();
            Ah.Show();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_accounts Aac = new Admin_accounts();
            Aac.Show();
        }
    }
}
