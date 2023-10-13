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
    public partial class Faculty_dept : Form
    {
        public Faculty_dept()
        {
            InitializeComponent();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Faculty_Profile Ap = new Faculty_Profile();
            Ap.Show();
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            faculty_courses Fc = new faculty_courses();
            Fc.Show();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
