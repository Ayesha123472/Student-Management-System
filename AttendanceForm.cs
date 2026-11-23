using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_System
{
    public partial class AttendenceForm : Form
    {
        string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        public AttendenceForm()
        {
            InitializeComponent();

            cmbStatus.Items.Add("Present");
            cmbStatus.Items.Add("Absent");
            cmbStatus.Items.Add("Leave");

            cmbStatus.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter Student ID.");
                return;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select attendance status.");
                return;
            }

            int studentID;

            if (!int.TryParse(txtStudentID.Text, out studentID))
            {
                MessageBox.Show("Student ID must be a number.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check whether Student exists
                    string checkQuery =
                        "SELECT COUNT(*) FROM Students WHERE StudentID = @StudentID";

                    using (SqlCommand checkCmd =
                        new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@StudentID", studentID);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Student ID does not exist.");
                            return;
                        }
                    }

                    // Insert attendance
                    string query = @"
                        INSERT INTO Attendence
                        (StudentID, StudentStatus, AttendenceDate)
                        VALUES
                        (@StudentID, @StudentStatus, @AttendenceDate)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue(
                            "@StudentStatus",
                            cmbStatus.Text
                        );
                        cmd.Parameters.AddWithValue(
                            "@AttendenceDate",
                            dtpDate.Value.Date
                        );

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Attendance saved successfully.");

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtStudentID.Clear();
            cmbStatus.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }
    }
}