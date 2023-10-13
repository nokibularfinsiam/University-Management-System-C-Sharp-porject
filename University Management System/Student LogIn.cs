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

namespace University_Management_System
{
    public partial class Student_LogIn : Form
    {
        public Student_LogIn()
        {
            InitializeComponent();
        }

        private void Student_LogIn_Load(object sender, EventArgs e)
        {

        }

        private void GetAdmission_Click(object sender, EventArgs e)
        {
            Student_Admission_Form admission_Form = new Student_Admission_Form();
            admission_Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student_Admission_Form admission_Form = new Student_Admission_Form();
            admission_Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection conn = null;
            try
            {

                string sql = "select * from StudentInfo where Email = '" + this.EmailBox.Text + "' and Password = '" + this.passBox.Text + "';";
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=""University manage"";Integrated Security=True");
                conn.Open();
                SqlCommand sqlcom = new SqlCommand(sql, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Valid User");
                    new Student_profile().Show();

                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, please try again\n" + ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forget_Password Fp = new Forget_Password();
            Fp.Show();
        }
    }
}
