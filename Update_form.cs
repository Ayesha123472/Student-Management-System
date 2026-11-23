using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_System
{
    public partial class Update_form : Form
    {
        string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        string oldStudentID;

        public Update_form()
        {
            InitializeComponent();
        }

        // SEARCH BUTTON
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Student ID.");
                return;
            }

            string query = @"SELECT * FROM Students
                             WHERE StudentID = @StudentID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@StudentID",
                            txtStudentID.Text.Trim()
                        );

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Save OLD Student ID
                                oldStudentID = reader["StudentID"].ToString();

                                txtStudentID.Text =
                                    reader["StudentID"].ToString();

                                txtStudentName.Text =
                                    reader["Name"].ToString();

                                txtFatherName.Text =
                                    reader["FatherName"].ToString();

                                txtAge.Text =
                                    reader["Age"].ToString();

                                cmbGender.Text =
                                    reader["Gender"].ToString();

                                txtPhone.Text =
                                    reader["Phone"].ToString();

                                txtAddress.Text =
                                    reader["Address"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Student not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // UPDATE BUTTON
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (oldStudentID == null || oldStudentID == "")
            {
                MessageBox.Show("Please search for a student first.");
                return;
            }

            string query = @"UPDATE Students
                             SET Name = @Name,
                                 FatherName = @FatherName,
                                 Age = @Age,
                                 Gender = @Gender,
                                 Phone = @Phone,
                                 Address = @Address
                             WHERE StudentID = @OldStudentID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@OldStudentID",
                            oldStudentID
                        );

                        cmd.Parameters.AddWithValue(
                            "@Name",
                            txtStudentName.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@FatherName",
                            txtFatherName.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@Age",
                            txtAge.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@Gender",
                            cmbGender.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@Phone",
                            txtPhone.Text.Trim()
                        );

                        cmd.Parameters.AddWithValue(
                            "@Address",
                            txtAddress.Text.Trim()
                        );

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show(
                                "Student information updated successfully!"
                            );
                        }
                        else
                        {
                            MessageBox.Show("Student not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // CLEAR BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            txtStudentName.Text = "";
            txtFatherName.Text = "";
            txtAge.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";

            cmbGender.SelectedIndex = -1;

            oldStudentID = "";
        }

        private void Update_form_Load(object sender, EventArgs e)
        {

        }
    }
}