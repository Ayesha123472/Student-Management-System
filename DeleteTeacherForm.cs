
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_System
{
    public partial class DeleteTeacherForm : Form
    {
        string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        public DeleteTeacherForm()
        {
            InitializeComponent();
        }

        // Form Load
        private void DeleteTeacherForm_Load(object sender, EventArgs e)
        {
            txtTeacherName.ReadOnly = true;
            txtTeacherName.Clear();
        }

        // Show teacher name when ID is entered
        private void textId_TextChanged(object sender, EventArgs e)
        {
            ShowTeacherName();
        }

        // Search teacher name from database
        private void ShowTeacherName()
        {
            txtTeacherName.Clear();

            if (string.IsNullOrWhiteSpace(textId.Text))
                return;

            int teacherID;

            if (!int.TryParse(textId.Text, out teacherID))
            {
                txtTeacherName.Text = "Enter a valid Teacher ID";
                return;
            }

            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    string query =
                        "SELECT TeacherName FROM Teacher WHERE TeacherID = @TeacherID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@TeacherID", SqlDbType.Int).Value =
                            teacherID;

                        con.Open();

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            txtTeacherName.Text = result.ToString();
                        }
                        else
                        {
                            txtTeacherName.Text = "Teacher not found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error searching teacher: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Delete teacher record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textId.Text))
            {
                MessageBox.Show(
                    "Please enter Teacher ID.",
                    "Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textId.Focus();
                return;
            }

            int teacherID;

            if (!int.TryParse(textId.Text, out teacherID))
            {
                MessageBox.Show(
                    "Please enter a valid Teacher ID.",
                    "Invalid ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                string teacherName = "";

                // Verify teacher record
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    string searchQuery =
                        "SELECT TeacherName FROM Teacher WHERE TeacherID = @TeacherID";

                    using (SqlCommand cmd =
                        new SqlCommand(searchQuery, con))
                    {
                        cmd.Parameters.Add("@TeacherID", SqlDbType.Int).Value =
                            teacherID;

                        con.Open();

                        object result = cmd.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                        {
                            MessageBox.Show(
                                "Teacher record not found.",
                                "Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            txtTeacherName.Clear();
                            return;
                        }

                        teacherName = result.ToString();
                    }
                }

                // Confirmation
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this teacher?\n\n" +
                    "Teacher ID: " + teacherID +
                    "\nTeacher Name: " + teacherName,
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection con =
                        new SqlConnection(connectionString))
                    {
                        string deleteQuery =
                            "DELETE FROM Teacher WHERE TeacherID = @TeacherID";

                        using (SqlCommand cmd =
                            new SqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.Add("@TeacherID", SqlDbType.Int).Value =
                                teacherID;

                            con.Open();

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show(
                                    "Teacher deleted successfully!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                textId.Clear();
                                txtTeacherName.Clear();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Teacher record could not be deleted.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database Error: " + ex.Message +
                    "\n\nIf this teacher is assigned to a course, " +
                    "remove or update the related course record first.",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
