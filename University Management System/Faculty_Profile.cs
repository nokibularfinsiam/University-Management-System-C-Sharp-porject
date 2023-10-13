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
    public partial class Faculty_Profile : Form
    {
        public Faculty_Profile()
        {
            InitializeComponent();
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            faculty_courses Ac = new faculty_courses();
            Ac.Show();
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

        private void Faculty_Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
