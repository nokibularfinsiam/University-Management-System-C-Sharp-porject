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
    public partial class faculty_courses : Form
    {
        public faculty_courses()
        {
            InitializeComponent();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Faculty_Profile Ap = new Faculty_Profile();
            Ap.Show();
        }

        private void buttonDep_Click(object sender, EventArgs e)
        {
            Faculty_dept Fd = new Faculty_dept();
            Fd.Show();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
