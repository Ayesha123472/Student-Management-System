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

namespace Student_System
{
    public partial class CoursesForm : Form
    {
        string connectionString =
    @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        public CoursesForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           ClearFields();

        }
        private void ClearFields()
        {
            txtCourseID.Clear();
            txtTeacherID.Clear();
            txtCourseName.Clear();
            txtCourseFee.Clear();
            
        }

        private void txtCourseFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseID.Text))
            {
                MessageBox.Show("Please enter Course ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTeacherID.Text))
            {
                MessageBox.Show("Please enter Teacher ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Please enter Course Name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCourseFee.Text))
            {
                MessageBox.Show("Please enter Course Fee.");
                return;
            }

            int courseID;
            int teacherID;
            int courseFee;

            if (!int.TryParse(txtCourseID.Text.Trim(), out courseID))
            {
                MessageBox.Show("Course ID must be a number.");
                return;
            }

            if (!int.TryParse(txtTeacherID.Text.Trim(), out teacherID))
            {
                MessageBox.Show("Teacher ID must be a number.");
                return;
            }

            if (!int.TryParse(txtCourseFee.Text.Trim(), out courseFee))
            {
                MessageBox.Show("Course Fee must be a number.");
                return;
            }

            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check Teacher ID
                    string checkTeacher =
                        "SELECT COUNT(*) FROM Teacher WHERE TeacherID = @TeacherID";

                    using (SqlCommand cmdTeacher =
                        new SqlCommand(checkTeacher, con))
                    {
                        cmdTeacher.Parameters.Add("@TeacherID", SqlDbType.Int)
                            .Value = teacherID;

                        int teacherCount =
                            (int)cmdTeacher.ExecuteScalar();

                        if (teacherCount == 0)
                        {
                            MessageBox.Show(
                                "This Teacher ID does not exist.");
                            return;
                        }
                    }

                    // Check Course ID
                    string checkCourse =
                        "SELECT COUNT(*) FROM Courses WHERE CourseID = @CourseID";

                    using (SqlCommand cmdCourse =
                        new SqlCommand(checkCourse, con))
                    {
                        cmdCourse.Parameters.Add("@CourseID", SqlDbType.Int)
                            .Value = courseID;

                        int courseCount =
                            (int)cmdCourse.ExecuteScalar();

                        if (courseCount > 0)
                        {
                            MessageBox.Show(
                                "This Course ID already exists.");
                            return;
                        }
                    }

                    // Insert Course
                    string query = @"
                        INSERT INTO Courses
                        (CourseID, TeacherID, CourseName, CourseFee)
                        VALUES
                        (@CourseID, @TeacherID, @CourseName, @CourseFee)";

                    using (SqlCommand cmd =
                        new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@CourseID", SqlDbType.Int)
                            .Value = courseID;

                        cmd.Parameters.Add("@TeacherID", SqlDbType.Int)
                            .Value = teacherID;

                        cmd.Parameters.Add("@CourseName",
                            SqlDbType.VarChar, 50)
                            .Value = txtCourseName.Text.Trim();

                        cmd.Parameters.Add("@CourseFee", SqlDbType.Int)
                            .Value = courseFee;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Course saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
