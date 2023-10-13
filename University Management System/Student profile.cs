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
    public partial class Student_profile : Form
    {
        public Student_profile()
        {
            InitializeComponent();
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            Student_courses Sc= new Student_courses();
            Sc.Show();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Student_profile_Load(object sender, EventArgs e)
        {

        }
    }
}
