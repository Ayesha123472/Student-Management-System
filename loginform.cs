using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_System
{
    public partial class loginform : Form
    {
        private string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        public loginform()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Please enter Username and Password.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT Role
                FROM Users
                WHERE Username = @Username
                AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString().Trim();

                            // Admin, Teacher or Student
                            if (role == "Admin" ||
                                role == "Teacher" ||
                                role == "Student")
                            {
                                Dashboardform dashboard =
                                    new Dashboardform(role);

                                dashboard.Show();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Invalid role in Users table.",
                                    "Login Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid Username or Password!",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            txtPassword.Clear();
                            txtUsername.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database Error:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
    }

