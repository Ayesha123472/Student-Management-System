using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_System
{
    public partial class Dashboardform : Form
    {
        private string userRole;

        // Database Connection
        private string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        public Dashboardform(string role)
        {
            InitializeComponent();

            userRole = role;

            // Panels initially hidden
            panelStudent.Visible = false;
            panelTeacher.Visible = false;

            // Role Based Access
            if (userRole == "Teacher")
            {
                // Teacher cannot add/delete students
                btnAddStudent.Enabled = false;
                btnDeleteStudent.Enabled = false;

                // Teacher cannot manage teachers
                btnAddTeacher.Enabled = false;
                btnUpdateTeacher.Enabled = false;
                btnDeleteTeacher.Enabled = false;
            }
        }

        // ==========================================
        // FORM LOAD
        // ==========================================

        private void Dashboardform_Load(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelTeacher.Visible = false;

            // Load database counts
            LoadDashboardCounts();
        }


        // ==========================================
        // LOAD DATABASE COUNTS
        // ==========================================

        private void LoadDashboardCounts()
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    // -----------------------------
                    // Students Count
                    // -----------------------------

                    string studentQuery =
                        "SELECT COUNT(*) FROM Students";

                    using (SqlCommand cmd =
                        new SqlCommand(studentQuery, con))
                    {
                        int studentCount =
                            Convert.ToInt32(cmd.ExecuteScalar());

                        button7.Text =
                            "Students " + studentCount;
                    }


                    // -----------------------------
                    // Teachers Count
                    // -----------------------------

                    string teacherQuery =
                        "SELECT COUNT(*) FROM Teacher";

                    using (SqlCommand cmd =
                        new SqlCommand(teacherQuery, con))
                    {
                        int teacherCount =
                            Convert.ToInt32(cmd.ExecuteScalar());

                        button8.Text =
                            "Teachers " + teacherCount;
                    }


                    // -----------------------------
                    // Courses Count
                    // -----------------------------

                    string courseQuery =
                        "SELECT COUNT(*) FROM Courses";

                    using (SqlCommand cmd =
                        new SqlCommand(courseQuery, con))
                    {
                        int courseCount =
                            Convert.ToInt32(cmd.ExecuteScalar());

                        button9.Text =
                            "Courses " + courseCount;
                    }


                    // -----------------------------
                    // Classes Count
                    // -----------------------------

                    string classQuery =
                        "SELECT COUNT(*) FROM Class";

                    using (SqlCommand cmd =
                        new SqlCommand(classQuery, con))
                    {
                        int classCount =
                            Convert.ToInt32(cmd.ExecuteScalar());

                        button11.Text =
                            "Class " + classCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection error:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ==========================================
        // DASHBOARD BUTTON
        // ==========================================

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelTeacher.Visible = false;

            // Refresh counts
            LoadDashboardCounts();
        }


        // ==========================================
        // STUDENTS MENU
        // ==========================================

        private void btnStudents_Click_1(object sender, EventArgs e)
        {
            panelStudent.Visible = true;
            panelTeacher.Visible = false;
        }


        // ==========================================
        // ADD STUDENT
        // ==========================================

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            AddStudentsform form = new AddStudentsform();
            form.Show();
        }


        // ==========================================
        // UPDATE STUDENT
        // ==========================================

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            Update_form form = new Update_form();
            form.Show();
        }


        // ==========================================
        // VIEW STUDENT
        // ==========================================

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            ViewStudentForm form = new ViewStudentForm();
            form.Show();
        }


        // ==========================================
        // DELETE STUDENT
        // ==========================================

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteForm form = new DeleteForm();
            form.Show();
        }


        // ==========================================
        // TEACHERS MENU
        // ==========================================

        private void btnTeachers_Click_1(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelTeacher.Visible = true;
    
        }


        // ==========================================
        // ADD TEACHER
        // ==========================================

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm form = new AddTeacherForm();
            form.Show();
        }


        // ==========================================
        // VIEW TEACHER
        // ==========================================

        private void btnViewTeacher_Click_1(object sender, EventArgs e)
        {
            ViewTeacherForm form = new ViewTeacherForm();
            form.Show();
        }


        // ==========================================
        // UPDATE TEACHER
        // ==========================================

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            UpdateTeacherForm form = new UpdateTeacherForm();
            form.Show();
        }


        // ==========================================
        // DELETE TEACHER
        // ==========================================

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            DeleteTeacherForm form = new DeleteTeacherForm();
            form.Show();
        }


        // ==========================================
        // COURSES
        // ==========================================

        private void btnCourses_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelTeacher.Visible = false;
            CoursesForm form = new CoursesForm();
            form.Show();

            }


        // ==========================================
        // ATTENDANCE
        // ==========================================

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelTeacher.Visible = false;
            AttendenceForm form = new AttendenceForm();
            form.Show();


             }


        // ==========================================
        // CLASS
        // ==========================================

        private void btnClass_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelTeacher.Visible = false;
            ClassForm form = new ClassForm();
            form.Show();

             }


        // ==========================================
        // LOGOUT
        // ==========================================

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                loginform login = new loginform();

                login.Show();

                this.Hide();
            }
        }


        // ==========================================
        // EMPTY LABEL EVENT
        // ==========================================

        private void label1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
