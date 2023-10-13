using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace University_Management_System
{
    public partial class Admin_Students : Form
    {
        public Admin_Students()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Faculty Af = new Admin_Faculty();
            Af.Show();
        }

        private void buttonDep_Click(object sender, EventArgs e)
        {
            Admin_department Ad = new Admin_department();
            Ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_home Ah = new Admin_home();
            Ah.Show();
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            Admin_Courses Ac = new Admin_Courses();
            Ac.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_accounts Aac = new Admin_accounts();
            Aac.Show();
        }

        private void Admin_Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'university_manageDataSet3.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter1.Fill(this.university_manageDataSet3.StudentInfo);
            // TODO: This line of code loads data into the 'university_manageDataSet2.StudentInfo' table. You can move, or remove it, as needed.
            //this.studentInfoTableAdapter1.Fill(this.university_manageDataSet2.StudentInfo);
            // TODO: This line of code loads data into the 'university_manageDataSet1.StudentInfo' table. You can move, or remove it, as needed.
            //this.studentInfoTableAdapter1.Fill(this.university_manageDataSet1.StudentInfo);
            // TODO: This line of code loads data into the 'university_manageDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.university_manageDataSet.StudentInfo);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True ");
                conn.Open();

                string query = "Delete * from StudentInfo where StudentName, FathersName, MothersName, Gender, Religion, BloodGroup, Email, Password, ContactInfo, Country, DOB, SSCGPA, SSCGroup, HSCGPA, HSCGroup, Program, PresentAdd, PermanentAdd, Image";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();

                MessageBox.Show(" Successfully deleted!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }



}
