
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_System
{
    public partial class DeleteForm : Form
    {
        string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            txtStudentName.ReadOnly = true;
            txtStudentName.Clear();
        }

        // Show student name when ID is entered
        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            ShowStudentName();
        }

        // Search student name from database
        private void ShowStudentName()
        {
            txtStudentName.Clear();

            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
                return;

            int studentID;

            if (!int.TryParse(txtStudentID.Text, out studentID))
            {
                txtStudentName.Text = "Enter a valid Student ID";
                return;
            }

            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    string query =
                        "SELECT Name FROM Students WHERE StudentID = @StudentID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value =
                            studentID;

                        con.Open();

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                            txtStudentName.Text = result.ToString();
                        else
                            txtStudentName.Text = "Student not found";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error searching student: " + ex.Message);
            }
        }

        // Delete student record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please enter Student ID.");
                txtStudentID.Focus();
                return;
            }

            int studentID;

            if (!int.TryParse(txtStudentID.Text, out studentID))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }

            try
            {
                string studentName = "";

                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    string searchQuery =
                        "SELECT Name FROM Students WHERE StudentID = @StudentID";

                    using (SqlCommand cmd =
                        new SqlCommand(searchQuery, con))
                    {
                        cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value =
                            studentID;

                        con.Open();

                        object result = cmd.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                        {
                            MessageBox.Show("Student record not found.");
                            txtStudentName.Clear();
                            return;
                        }

                        studentName = result.ToString();
                    }
                }

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this student?\n\n" +
                    "Student ID: " + studentID +
                    "\nStudent Name: " + studentName,
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection con =
                        new SqlConnection(connectionString))
                    {
                        string deleteQuery =
                            "DELETE FROM Students WHERE StudentID = @StudentID";

                        using (SqlCommand cmd =
                            new SqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value =
                                studentID;

                            con.Open();

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show(
                                    "Student deleted successfully!");

                                txtStudentID.Clear();
                                txtStudentName.Clear();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Student record could not be deleted.");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database Error: " + ex.Message +
                    "\nIf this student is linked to another record, " +
                    "remove or update that related record first.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
