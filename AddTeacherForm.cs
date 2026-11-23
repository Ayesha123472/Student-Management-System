using System;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_System
{
    public partial class AddTeacherForm : Form
    {
        string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        public AddTeacherForm()
        {
            InitializeComponent();

            // Gender options
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get values from form
            string teacherIDText = txtTeacherID.Text;
            string name = txtName.Text;
            string phone = txtPhoneNo.Text;
            string address = txtAddress.Text;
            string gender = cmbGender.Text;

            // Check empty fields
            if (teacherIDText == "" ||
                name == "" ||
                phone == "" ||
                address == "" ||
                gender == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            // Check TeacherID
            int teacherID;

            if (!int.TryParse(teacherIDText, out teacherID))
            {
                MessageBox.Show("Teacher ID must be a number.");
                return;
            }

            // Insert query
            string query = @"INSERT INTO Teacher
                             (TeacherID, TeacherName, PhoneNO, TeacherAddress, Gender)
                             VALUES
                             (@TeacherID, @TeacherName, @PhoneNO, @TeacherAddress, @Gender)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TeacherID", teacherID);
                        cmd.Parameters.AddWithValue("@TeacherName", name);
                        cmd.Parameters.AddWithValue("@PhoneNO", phone);
                        cmd.Parameters.AddWithValue("@TeacherAddress", address);
                        cmd.Parameters.AddWithValue("@Gender", gender);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Teacher information saved successfully!");

                    // Clear fields after saving
                    txtTeacherID.Clear();
                    txtName.Clear();
                    txtPhoneNo.Clear();
                    txtAddress.Clear();
                    cmbGender.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields
            txtTeacherID.Clear();
            txtName.Clear();
            txtPhoneNo.Clear();
            txtAddress.Clear();
            cmbGender.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}