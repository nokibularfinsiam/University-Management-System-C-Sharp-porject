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
    public partial class Student_courses : Form
    {
        public Student_courses()
        {
            InitializeComponent();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Student_profile Sp = new Student_profile();
            Sp.Show();
        }

        private void Student_courses_Load(object sender, EventArgs e)
        {

        }
    }
}
